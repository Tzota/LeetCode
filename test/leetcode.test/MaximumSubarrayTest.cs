
using leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{
    [TestClass]
    public class MaximumSubarrayTest
    {
        [TestMethod]
        public void MaximumSubarray_In_Out()
        {
            var input = new int [] {-2,1,-3,4,-1,2,1,-5,4};
            Assert.AreEqual(6, new MaximumSubarray().MaxSubArray(input));
        }

        [TestMethod]
        public void MaximumSubarray_Empty_Zero()
        {
            var input = new int [0];
            Assert.AreEqual(0, new MaximumSubarray().MaxSubArray(input));
        }

        [TestMethod]
        public void MaximumSubarray_One_Identity()
        {
            var input = new int [] {-2};
            Assert.AreEqual(-2, new MaximumSubarray().MaxSubArray(input));
        }

        [TestMethod]
        public void MaximumSubarray_In2_Out2()
        {
            var input = new int [] {1,2};
            Assert.AreEqual(3, new MaximumSubarray().MaxSubArray(input));
        }

        [TestMethod]
        public void MaximumSubarray_In3_Out3()
        {
            var input = new int [] {1,2,3,-10, 3};
            Assert.AreEqual(6, new MaximumSubarray().MaxSubArray(input));
        }

        [TestMethod]
        public void MaximumSubarray_SinglePositiveNumber()
        {
            var input = new int [] {-1, -2, 3, -10, -3};
            Assert.AreEqual(3, new MaximumSubarray().MaxSubArray(input));
        }
    }
}
