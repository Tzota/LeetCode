using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{
    [TestClass]
    public class PalindromeNumberTest
    {
        [TestMethod]
        public void PalindromeNumberTest_SmallInt_OK()
        {
            var answer = (new PalindromeNumber()).Execute(1);
            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void PalindromeNumberTest_SimpleInt_OK()
        {
            var answer = (new PalindromeNumber()).Execute(123);
            Assert.IsFalse(answer);
        }

        [TestMethod]
        public void PalindromeNumberTest_NegativeIntOdd_OK()
        {
            var answer = (new PalindromeNumber()).Execute(-123);
            Assert.IsFalse(answer);
        }

        [TestMethod]
        public void PalindromeNumberTest_PositivePalindrome_OK()
        {
            var answer = (new PalindromeNumber()).Execute(12321);
            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void PalindromeNumberTest_NegativePalindrome_OK()
        {
            var answer = (new PalindromeNumber()).Execute(-12321);
            Assert.IsFalse(answer);
        }

        [TestMethod]
        public void PalindromeNumberTest_BigNegativePalindrome_OK()
        {
            var answer = (new PalindromeNumber()).Execute(-2147447412);
            Assert.IsFalse(answer);
        }
    }
}