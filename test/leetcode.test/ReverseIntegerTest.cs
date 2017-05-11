using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{
    [TestClass]
    public class ReverseIntegerTest
    {
        [TestMethod]
        public void ReverseIntegerTest_SmallInt_OK()
        {
            var answer = (new ReverseInteger()).Execute(1);
            Assert.AreEqual(1, answer);
        }

        [TestMethod]
        public void ReverseIntegerTest_SimpleInt_OK()
        {
            var answer = (new ReverseInteger()).Execute(123);
            Assert.AreEqual(321, answer);
        }

        [TestMethod]
        public void ReverseIntegerTest_NegativeIntOdd_OK()
        {
            var answer = (new ReverseInteger()).Execute(-123);
            Assert.AreEqual(-321, answer);
        }

        [TestMethod]
        public void ReverseIntegerTest_NegativeIntEven_OK()
        {
            var answer = (new ReverseInteger()).Execute(-1234);
            Assert.AreEqual(-4321, answer);
        }

        [TestMethod]
        public void ReverseIntegerTest_Overflow_Zero()
        {
            // 2147483647
            // 1111111113
            var answer = (new ReverseInteger()).Execute(1111111113);
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void ReverseIntegerTest_TrailingZero_OK()
        {
            var answer = (new ReverseInteger()).Execute(100);
            Assert.AreEqual(1, answer);
        }

        [TestMethod]
        public void ReverseIntegerTest_DoubleOverflow_Zero()
        {
            var answer = (new ReverseInteger()).Execute(1534236469);
            Assert.AreEqual(0, answer);
        }


    }
}