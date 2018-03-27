
using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{
    [TestClass]
    public class ValidParenthesesTest
    {
        [TestMethod]
        public void ValidParentheses_Empty_OK()
        {
            Assert.IsTrue(new ValidParentheses().IsValid(""));
        }

        [TestMethod]
        public void ValidParentheses_Edge_OK()
        {
            Assert.IsTrue(new ValidParentheses().IsValid("()"));
        }

        [TestMethod]
        public void ValidParentheses_Simple_OK()
        {
            Assert.IsTrue(new ValidParentheses().IsValid("({[]})"));
        }

        [TestMethod]
        public void ValidParentheses_WrongSimpleOpening_Fail()
        {
            Assert.IsFalse(new ValidParentheses().IsValid("("));
        }

        [TestMethod]
        public void ValidParentheses_WrongSimpleClosing_Fail()
        {
            Assert.IsFalse(new ValidParentheses().IsValid("]"));
        }

        [TestMethod]
        public void ValidParentheses_Wrong_Fail()
        {
            Assert.IsFalse(new ValidParentheses().IsValid("({]"));
        }
    }
}
