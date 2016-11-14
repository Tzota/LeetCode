using System.Collections.Generic;

namespace leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    ///
    /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    /// You may assume that each input would have exactly one solution.
    /// </summary>
    public class TwoSum
    {
        /// <summary>
        /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        /// </summary>
        /// <param name="nums">array of integers</param>
        /// <param name="target">target sum to achieve</param>
        /// <returns>indices of the two numbers such that they add up to a target</returns>
        public int[] Find(int[] nums, int target)
        {
            var diffs = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (diffs.ContainsKey(num)) {
                    return new int[] {i, diffs[num] };
                }

                if (!diffs.ContainsKey(target - num)) {
                    // "each input would have exactly one solution" - so this is definitely not the case
                    diffs.Add(target - num, i);
                }
            }
            return new int[] { 0, 0};
        }
    }
}