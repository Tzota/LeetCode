
using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{
    [TestClass]
    public class ImplementstrStrTest
    {
        [TestMethod]
        public void ImplementstrStr_NeddleLongerThanHaystack_NoResult()
        {
            Assert.AreEqual(-1, (new ImplementstrStr().StrStr("aaa", "aaaaaaa")));
        }

        [TestMethod]
        public void ImplementstrStr_Start_0()
        {
            Assert.AreEqual(0, (new ImplementstrStr().StrStr("1234567", "123")));
        }

        [TestMethod]
        public void ImplementstrStr_End_0()
        {
            Assert.AreEqual(4, (new ImplementstrStr().StrStr("1234567", "567")));
        }

        [TestMethod]
        public void ImplementstrStr_Middle_0()
        {
            Assert.AreEqual(2, (new ImplementstrStr().StrStr("1234567", "345")));
        }

        [TestMethod]
        public void ImplementstrStr_SeemsInEnd_NoResult()
        {
            Assert.AreEqual(-1, (new ImplementstrStr().StrStr("1234567", "678")));
        }
    }
}
