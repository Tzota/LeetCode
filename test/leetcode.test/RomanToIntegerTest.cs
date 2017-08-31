using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace leetcode_test
{
    [TestClass]
    public class RomanToIntegerTest
    {
        [TestMethod]
        public void RomanToInteger_OneDigit_OK()
        {
            int answer = new RomanToInteger().RomanToInt("I");
            Assert.AreEqual(1, answer);
        }

        [TestMethod]
        public void RomanToInteger_TwoSimpleDigits_OK()
        {
            int answer = new RomanToInteger().RomanToInt("II");
            Assert.AreEqual(2, answer);
        }
        
        [TestMethod]
        public void RomanToInteger_TwoComplexDigits_OK()
        {
            int answer = new RomanToInteger().RomanToInt("IX");
            Assert.AreEqual(9, answer);
        }

        
        [TestMethod]
        public void RomanToInteger_BigNumber_OK()
        {
            int answer = new RomanToInteger().RomanToInt("MCMLXXXVIII");
            Assert.AreEqual(1988, answer);
        }
    }
}