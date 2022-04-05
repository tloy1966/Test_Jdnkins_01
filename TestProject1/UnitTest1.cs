using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jenkins_Test_01;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            foo1 foo = new foo1();
            var result = foo.fun1();

            Assert.AreEqual(result, "foo1");
        }
    }
}
