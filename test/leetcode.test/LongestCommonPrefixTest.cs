using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace leetcode_test
{
    [TestClass]
    public class LongestCommonPrefixTest
    {
        [TestMethod]
        public void LongestCommonPrefixTest_EmptyString_EmptyString()
        {
            var answer = (new LongestCommonPrefix()).Find(new string[]{"", ""});
            Assert.AreEqual(String.Empty, answer);
        }

        [TestMethod]
        public void LongestCommonPrefixTest_NothingCommon_EmptyString()
        {
            var answer = (new LongestCommonPrefix()).Find(new string[]{"a", "b"});
            Assert.AreEqual(String.Empty, answer);
        }

        [TestMethod]
        public void LongestCommonPrefixTest_SomethingCommon_GivesPrefix()
        {
            var answer = (new LongestCommonPrefix()).Find(new string[]{"aaa1", "aaa2"});
            Assert.AreEqual("aaa", answer);
        }

        [TestMethod]
        public void LongestCommonPrefixTest_AllCommon_GivesPrefix()
        {
            var answer = (new LongestCommonPrefix()).Find(new string[]{"aaa", "aaa"});
            Assert.AreEqual("aaa", answer);
        }

        [TestMethod]
        public void LongestCommonPrefixTest_FirstIsShorter_GivesPrefix()
        {
            var answer = (new LongestCommonPrefix()).Find(new string[]{"aaa", "aaabb"});
            Assert.AreEqual("aaa", answer);
        }

        [TestMethod]
        public void LongestCommonPrefixTest_SecondIsShorter_GivesPrefix()
        {
            var answer = (new LongestCommonPrefix()).Find(new string[]{"aaabb", "aaa"});
            Assert.AreEqual("aaa", answer);
        }

        [TestMethod]
        public void LongestCommonPrefixTest_OneString_EmptyString()
        {
            var answer = (new LongestCommonPrefix()).Find(new string[]{"a"});
            Assert.AreEqual("a", answer);
        }

        [TestMethod]
        public void LongestCommonPrefixTest_OneLetter_EmptyString()
        {
            var answer = (new LongestCommonPrefix()).Find(new string[]{"a", "a", "b"});
            Assert.AreEqual("", answer);
        }
    }
}
