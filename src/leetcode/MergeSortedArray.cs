namespace leetcode
{
    /// <summary>
    /// <para>Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.</para>
    /// <para>https://leetcode.com/problems/merge-sorted-array/</para>
    /// <para>Note:</para>
    /// <list type="bullet">
    ///     <item>The number of elements initialized in nums1 and nums2 are m and n respectively.</item>
    ///     <item>You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.</item>
    /// </list>
    /// </summary>
    /// <example>
    ///   Input:
    ///   nums1 = [1,2,3,0,0,0], m = 3
    ///   nums2 = [2,5,6],       n = 3
    ///
    ///   Output: [1,2,2,3,5,6]
    /// </example>
    public static class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;
            if (p2 < 0) return;
            for(int i = m + n - 1; i >= 0; i--)
            {
                if (p1 < 0 || nums1[p1] <= nums2[p2])
                {
                    nums1[i] = nums2[p2--];
                }
                else
                {
                    nums1[i] = nums1[p1--];
                }
                if (p2 < 0) break;
            }
        }
    }
}
