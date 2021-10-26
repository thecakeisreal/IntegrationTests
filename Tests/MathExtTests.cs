using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathExt;

namespace Tests
{
    [TestClass]
    public class MathExtTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, MathExt.MathExt.PGCD(3, 15));
        }
    }
}
