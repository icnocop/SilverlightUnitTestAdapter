using Microsoft.Silverlight.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace SilverlightUnitTest
{
    [TestClass]
    public class AsyncTest : SilverlightTest
    {
        [TestMethod]
        [Asynchronous]
        public void EnqueueTestComplete_ShouldPass()
        {
            this.EnqueueTestComplete();
        }

        [TestMethod]
        [Asynchronous]
        public void Assert_Fail_ShouldFail()
        {
            Assert.Fail("fail");
            this.EnqueueTestComplete();
        }

        [TestMethod]
        [Asynchronous]
        public Task ReturnTask_ShouldPass()
        {
            return Task.Factory.StartNew(() =>
            {
                this.EnqueueTestComplete();
            });
        }

        [TestMethod]
        [Asynchronous]
        public Task ReturnTask_WithAssertFail_ShouldFail()
        {
            return Task.Factory.StartNew(() =>
            {
                Assert.Fail("fail");
                this.EnqueueTestComplete();
            });
        }

        [TestMethod]
        [Asynchronous]
        public async Task AwaitTask_ShouldPass()
        {
            await Task.Factory.StartNew(() =>
            {
                this.EnqueueTestComplete();
            });
        }

        [TestMethod]
        [Asynchronous]
        public async Task AwaitTask_WithAssertFail_ShouldFail()
        {
            await Task.Factory.StartNew(() =>
            {
                Assert.Fail("fail");
            });

            this.EnqueueTestComplete();
        }
    }
}
