// <copyright file="RetryHelper.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Helpers
{
    using System;
    using System.Runtime.InteropServices;
    using System.Threading;

    /// <summary>
    /// Retry Helper.
    /// </summary>
    internal static class RetryHelper
    {
        /// <summary>
        /// Retries the specified function.
        /// </summary>
        /// <typeparam name="T">The return type</typeparam>
        /// <param name="func">The function.</param>
        /// <returns>The return value of the specified function.</returns>
        public static T Retry<T>(Func<T> func)
        {
            int retryCount = 0;
            int maxRetryCount = 100;

            while (retryCount <= maxRetryCount)
            {
                try
                {
                    return func();
                }
                catch (COMException ex)
                {
                    // System.Runtime.InteropServices.COMException(0x8001010A): The message filter indicated that the application is busy. (Exception from HRESULT: 0x8001010A(RPC_E_SERVERCALL_RETRYLATER))
                    if ((ex.HResult == -2147417846 /* 0x8001010A */)
                        ||
                        (ex.Message != "The message filter indicated that the application is busy. (Exception from HRESULT: 0x8001010A(RPC_E_SERVERCALL_RETRYLATER))"))
                    {
                        throw;
                    }

                    if (retryCount >= maxRetryCount)
                    {
                        throw;
                    }

                    Thread.Sleep(1000);
                }

                retryCount++;
            }

            return default(T);
        }

        /// <summary>
        /// Retries the specified action.
        /// </summary>
        /// <param name="action">The action.</param>
        public static void Retry(Action action)
        {
            Retry(new Func<int>(() =>
            {
                action();
                return 0;
            }));
        }
    }
}
