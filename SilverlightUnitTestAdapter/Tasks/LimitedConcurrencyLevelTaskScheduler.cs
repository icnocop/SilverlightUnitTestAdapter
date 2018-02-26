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

    public class LimitedConcurrencyLevelTaskScheduler : TaskScheduler
    {
        [ThreadStatic]
        private static bool currentThreadIsProcessingItems;

        private readonly LinkedList<Task> tasks = new LinkedList<Task>();

        private readonly int maxDegreeOfParallelism;

        private int delegatesQueuedOrRunning;

        public sealed override int MaximumConcurrencyLevel
        {
            get
            {
                return this.maxDegreeOfParallelism;
            }
        }

        public LimitedConcurrencyLevelTaskScheduler(int maxDegreeOfParallelism)
        {
            if (maxDegreeOfParallelism < 1)
            {
                int coreCount = 0;
                foreach (ManagementBaseObject item in new ManagementObjectSearcher("Select * from Win32_Processor").Get())
                {
                    coreCount += int.Parse(item["NumberOfCores"].ToString());
                }

                this.maxDegreeOfParallelism = coreCount - 1;
            }

            this.maxDegreeOfParallelism = maxDegreeOfParallelism;
        }

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

        private void NotifyThreadPoolOfPendingWork()
        {
            ThreadPool.UnsafeQueueUserWorkItem(_ => {
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

        protected sealed override bool TryDequeue(Task task)
        {
            bool flag;
            lock (this.tasks)
            {
                flag = this.tasks.Remove(task);
            }

            return flag;
        }

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
    }
}