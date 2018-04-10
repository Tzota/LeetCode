using System;

namespace leetcode
{
    /// <summary>
    /// Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
    /// For example, given the array [-2,1,-3,4,-1,2,1,-5,4],
    /// the contiguous subarray [4,-1,2,1] has the largest sum = 6.
    /// </summary>
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums) {
            if (nums.Length == 0) {
                return 0;
            }
            int ans = Int32.MinValue, sum = 0;
            for(int i = 0; i < nums.Length; i++) {
                sum += nums[i];
                ans = Math.Max(ans, sum);
                sum = Math.Max(sum, 0);
            }
            return ans;
        }
    }
}
