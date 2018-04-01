
namespace leetcode
{
    /// <summary>
    /// 26. Remove Duplicates from Sorted Array
    /// Given a sorted array, remove the duplicates in-place such that each element appear only once and return the new length.
    /// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
    /// </summary>
    public class RemoveDuplicatesfromSortedArray
    {
        public int RemoveDuplicates(int[] nums) {
            if (nums.Length < 2) {
                return nums.Length;
            }

            int a = 0;

            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[a] != nums[i])
                {
                    a++;
                    nums[a] = nums[i];
                }
            }
            return a + 1;
        }
    }
}
