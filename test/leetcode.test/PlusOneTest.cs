
using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{
    [TestClass]
    public class PlusOneTest
    {
        [TestMethod]
        public void PlusOne_0_1()
        {
            var actual = new PlusOne().Plus1(new [] {0});
            CollectionAssert.AreEqual(new []{1}, actual, System.String.Join(',', actual));
        }

        [TestMethod]
        public void PlusOne_5_6()
        {
            CollectionAssert.AreEqual(new []{6}, new PlusOne().Plus1(new [] {5}));
        }

        [TestMethod]
        public void PlusOne_15_16()
        {
            CollectionAssert.AreEqual(new []{1, 6}, new PlusOne().Plus1(new [] {1, 5}));
        }

        [TestMethod]
        public void PlusOne_9_10()
        {
            CollectionAssert.AreEqual(new []{1, 0}, new PlusOne().Plus1(new [] {9}));
        }

        [TestMethod]
        public void PlusOne_9999_10000()
        {
            var actual = new PlusOne().Plus1(new [] {9, 9, 9, 9});
            CollectionAssert.AreEqual(new []{1, 0, 0, 0, 0}, actual, System.String.Join("", actual));
        }
    }
}
