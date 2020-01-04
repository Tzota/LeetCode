using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_test
{
    [TestCategory("MergeSortedArray")]
    [TestClass]
    public class MergeSortedArrayTest
    {
        private readonly TestData[] data;

        public MergeSortedArrayTest()
        {
            data = new[] {
                new TestData {nums1 = new [] {1,2,3,0,0,0}, m=3, nums2 = new [] {2,5,6}, n=3, expected=new [] {1,2,2,3,5,6}},
                new TestData {nums1 = new int[0], m=0, nums2 = new int[0], n=0, expected = new int[0]},
                new TestData {nums1 = new [] {1}, m=1, nums2 = new int[0], n=0, expected = new []{1}},
                new TestData {nums1 = new []{0}, m=0, nums2 = new []{1}, n=1, expected = new []{1}},
                new TestData {nums1 = new [] {1,2,3,0,0,0}, m=3, nums2 = new [] {2}, n=1, expected=new [] {1,2,2,3,0,0}},
                new TestData {nums1 = new [] {2, 0, 0, 0}, m=1, nums2 = new [] {1,2,3,0,0,0}, n=3, expected=new [] {1,2,2,3}},
                new TestData {nums1 = new [] {0, 0, 0, 0}, m=0, nums2 = new [] {-2,-1,1,2}, n=4, expected=new [] {-2,-1,1,2}},
            };
        }

        [TestMethod]
        public void MergeSortedArray()
        {
            foreach (var d in data)
            {
                leetcode.MergeSortedArray.Merge(d.nums1, d.m, d.nums2, d.n);
                CollectionAssert.AreEqual(d.nums1, d.expected, d.ToString());
            }
        }

        class TestData
        {
            static int counter = 0;

            public int num = counter++;
            public int[] nums1;
            public int m;
            public int[] nums2;
            public int n;
            public int[] expected;

            public override string ToString()
            {
                return $"{num}|{string.Join(",", nums1)}|{m}|{string.Join(", ", nums2)}|{n}|{string.Join(", ", expected)}";
            }
        };
    }
}
