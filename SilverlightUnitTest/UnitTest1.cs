using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SilverlightUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            this.Log("Hello from Silverlight!");

            Assert.IsTrue(true, "Testing is fun!");
        }

        private void Log(string message)
        {
            // write message to the Debug Output window when run with the debugger
            Debug.WriteLine(message);

            // write message to the Tests Output window when run without the debugger
            Console.WriteLine(message);
        }
    }
}
