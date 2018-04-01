
using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace leetcode_test
{
    [TestClass]
    public class RemoveDuplicatesfromSortedArrayTest
    {
        [TestMethod]
        public void RemoveDuplicatesfromSortedArray_In_Out()
        {
            var arr = new int[]{1, 1, 2};
            Assert.AreEqual(2, (new RemoveDuplicatesfromSortedArray().RemoveDuplicates(arr)));
            CollectionAssert.AreEqual(new int[]{1, 2}, arr.Take(2).ToArray());
        }

        [TestMethod]
        public void RemoveDuplicatesfromSortedArray_EmptyIn_EmptyOut()
        {
            var arr = new int[0];
            Assert.AreEqual(0, (new RemoveDuplicatesfromSortedArray().RemoveDuplicates(arr)));
            CollectionAssert.AreEqual(new int[0], arr);
        }

        [TestMethod]
        public void RemoveDuplicatesfromSortedArray_NoDuplicatesIn_SameOut()
        {
            var arr = new int[]{1, 2, 3};
            Assert.AreEqual(3, (new RemoveDuplicatesfromSortedArray().RemoveDuplicates(arr)));
            CollectionAssert.AreEqual(new int[]{1, 2, 3}, arr);
        }

        [TestMethod]
        public void RemoveDuplicatesfromSortedArray_AllSame_OneOut()
        {
            var arr = new int[]{1, 1, 1, 1};
            Assert.AreEqual(1, (new RemoveDuplicatesfromSortedArray().RemoveDuplicates(arr)));
            CollectionAssert.AreEqual(new int[]{1}, arr.Take(1).ToArray());
        }
    }
}
