// <copyright file="AppDomainHelper.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Helpers
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Security.Policy;

    /// <summary>
    /// Application Domain Helper.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class AppDomainHelper : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppDomainHelper"/> class.
        /// </summary>
        public AppDomainHelper()
        {
            Evidence evidence = new Evidence(AppDomain.CurrentDomain.Evidence);
            AppDomainSetup setup = new AppDomainSetup
            {
                ApplicationBase = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
            };

            this.AppDomain = AppDomain.CreateDomain("SomeAppDomain", evidence, setup);
        }

        /// <summary>
        /// Gets the application domain.
        /// </summary>
        /// <value>The application domain.</value>
        public AppDomain AppDomain { get; private set; }

        /// <summary>
        /// Creates an instance in the domain.
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        /// <returns>T.</returns>
        public T CreateInstance<T>()
            where T : MarshalByRefObject
        {
            Type type = typeof(T);
            return (T)this.AppDomain.CreateInstanceAndUnwrap(
                type.Assembly.FullName,
                type.FullName);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            AppDomain.Unload(this.AppDomain);
            this.AppDomain = null;
        }

        /// <summary>
        /// Executes the specfied action in the domain.
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="action">The action.</param>
        public void ExecuteInDomain<T>(Action<T> action)
            where T : MarshalByRefObject, IDisposable
        {
            using (T instance = this.CreateInstance<T>())
            {
                action(instance);
            }
        }
    }
}
