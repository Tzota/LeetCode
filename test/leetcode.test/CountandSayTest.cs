
using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{
    [TestClass]
    public class CountandSayTest
    {
        [TestMethod]
        public void CountandSay_1_1()
        {
            Assert.AreEqual("1", new CountandSay().CountAndSay(1));
        }

        [TestMethod]
        public void CountandSay_2_11()
        {
            Assert.AreEqual("11", new CountandSay().CountAndSay(2));
        }

        [TestMethod]
        public void CountandSay_3_21()
        {
            Assert.AreEqual("21", new CountandSay().CountAndSay(3));
        }

        [TestMethod]
        public void CountandSay_4_1211()
        {
            Assert.AreEqual("1211", new CountandSay().CountAndSay(4));
        }
    }
}
