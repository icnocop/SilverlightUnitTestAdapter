// <copyright file="LimitedConcurrencyLevelTaskScheduler.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Tasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Limited Concurrency Level Task Scheduler.
    /// </summary>
    /// <seealso cref="System.Threading.Tasks.TaskScheduler" />
    public class LimitedConcurrencyLevelTaskScheduler : TaskScheduler
    {
        [ThreadStatic]
        private static bool currentThreadIsProcessingItems;

        private readonly LinkedList<Task> tasks = new LinkedList<Task>();

        private readonly int maxDegreeOfParallelism;

        private int delegatesQueuedOrRunning;

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitedConcurrencyLevelTaskScheduler"/> class.
        /// </summary>
        /// <param name="maxDegreeOfParallelism">The maximum degree of parallelism.</param>
        public LimitedConcurrencyLevelTaskScheduler(int maxDegreeOfParallelism)
        {
            if (maxDegreeOfParallelism < 1)
            {
                int coreCount = 0;
                using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_Processor"))
                {
                    foreach (ManagementBaseObject item in managementObjectSearcher.Get())
                    {
                        coreCount += int.Parse(item["NumberOfCores"].ToString());
                    }
                }

                this.maxDegreeOfParallelism = coreCount - 1;
            }

            this.maxDegreeOfParallelism = maxDegreeOfParallelism;
        }

        /// <summary>
        /// Gets the maximum concurrency level.
        /// </summary>
        /// <value>The maximum concurrency level.</value>
        public sealed override int MaximumConcurrencyLevel => this.maxDegreeOfParallelism;

        /// <summary>
        /// Gets the scheduled tasks.
        /// </summary>
        /// <returns>The tasks.</returns>
        protected sealed override IEnumerable<Task> GetScheduledTasks()
        {
            IEnumerable<Task> array;
            bool lockTaken = false;
            try
            {
                Monitor.TryEnter(this.tasks, ref lockTaken);
                if (!lockTaken)
                {
                    throw new NotSupportedException();
                }

                array = this.tasks.ToArray();
            }
            finally
            {
                if (lockTaken)
                {
                    Monitor.Exit(this.tasks);
                }
            }

            return array;
        }

        /// <summary>
        /// Queues the task.
        /// </summary>
        /// <param name="task">The task.</param>
        protected sealed override void QueueTask(Task task)
        {
            lock (this.tasks)
            {
                this.tasks.AddLast(task);
                if (this.delegatesQueuedOrRunning < this.maxDegreeOfParallelism)
                {
                    this.delegatesQueuedOrRunning++;
                    this.NotifyThreadPoolOfPendingWork();
                }
            }
        }

        /// <summary>
        /// Tries to dequeue the task.
        /// </summary>
        /// <param name="task">The task.</param>
        /// <returns><c>true</c> if the task was removed, <c>false</c> otherwise.</returns>
        protected sealed override bool TryDequeue(Task task)
        {
            bool flag;
            lock (this.tasks)
            {
                flag = this.tasks.Remove(task);
            }

            return flag;
        }

        /// <summary>
        /// Tries to execute the specified task inline.
        /// </summary>
        /// <param name="task">The task.</param>
        /// <param name="taskWasPreviouslyQueued">if set to <c>true</c> indicates the task was previously queued and will be dequeued before execution.</param>
        /// <returns><c>true</c> if successful, <c>false</c> otherwise.</returns>
        protected sealed override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            bool flag;
            if (currentThreadIsProcessingItems)
            {
                if (taskWasPreviouslyQueued)
                {
                    this.TryDequeue(task);
                }

                flag = this.TryExecuteTask(task);
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        private void NotifyThreadPoolOfPendingWork()
        {
            ThreadPool.UnsafeQueueUserWorkItem(
                _ =>
                {
                    Task item;
                    currentThreadIsProcessingItems = true;
                    try
                    {
                        while (true)
                        {
                            lock (this.tasks)
                            {
                                if (this.tasks.Count != 0)
                                {
                                    item = this.tasks.First.Value;
                                    this.tasks.RemoveFirst();
                                }
                                else
                                {
                                    this.delegatesQueuedOrRunning--;
                                    break;
                                }
                            }
                            this.TryExecuteTask(item);
                        }
                    }
                    finally
                    {
                        currentThreadIsProcessingItems = false;
                    }
                }, null);
        }
    }
}