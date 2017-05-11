using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace leetcode_test
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void TwoSum_Neighbours_OK()
        {
            int[] answer = new TwoSum().Find(new int[] { 2, 7, 11, 15 }, 9);
            Assert.AreEqual(1, answer.Where(o => o == 0).Count());
            Assert.AreEqual(1, answer.Where(o => o == 1).Count());
        }

        [TestMethod]
        public void TwoSum_Distant_OK()
        {
            int[] answer = new TwoSum().Find(new int[] { 2, 11, 7, 15 }, 9);
            Assert.AreEqual(1, answer.Where(o => o == 0).Count());
            Assert.AreEqual(1, answer.Where(o => o == 2).Count());
        }

        [TestMethod]
        public void TwoSum_NoExtraMembers_OK()
        {
            int[] answer = new TwoSum().Find(new int[] { 2, 7}, 9);
            Assert.AreEqual(1, answer.Where(o => o == 0).Count());
            Assert.AreEqual(1, answer.Where(o => o == 1).Count());
        }

        [TestMethod]
        public void TwoSum_RepeatingItems_OK()
        {
            int[] answer = new TwoSum().Find(new int[] { 2, 1, 1, 1, 1, 7}, 9);
            Assert.AreEqual(1, answer.Where(o => o == 0).Count());
            Assert.AreEqual(1, answer.Where(o => o == 5).Count());
        }
    }
}