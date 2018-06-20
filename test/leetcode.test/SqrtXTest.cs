
using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{
    [TestClass]
    public class SqrtXTest
    {
        [TestMethod]
        public void SqrtX_4_2()
        {
            Assert.AreEqual(2, new SqrtX().MySqrt(4));
        }

        [TestMethod]
        public void SqrtX_0_0()
        {
            Assert.AreEqual(0, new SqrtX().MySqrt(0));
        }

        [TestMethod]
        public void SqrtX_2_1()
        {
            Assert.AreEqual(1, new SqrtX().MySqrt(2));
        }

        [TestMethod]
        public void SqrtX_100_10()
        {
            Assert.AreEqual(10, new SqrtX().MySqrt(100));
        }

        [TestMethod]
        public void SqrtX_99_9()
        {
            Assert.AreEqual(9, new SqrtX().MySqrt(99));
        }
    }
}
