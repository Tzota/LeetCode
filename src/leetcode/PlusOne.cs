using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    /// <summary>
    /// Given a non-negative integer represented as a non-empty array of digits, plus one to the integer.
    ///
    /// You may assume the integer do not contain any leading zero, except the number 0 itself.
    ///
    /// The digits are stored such that the most significant digit is at the head of the list.
    /// </summary>
    public class PlusOne
    {
        public int[] Plus1(int[] digits) {
            var res =  new List<int>(digits.Length + 1);
            var overflow = 1;
            for(int i = 0; i < digits.Length; i++) {
                int n = digits[digits.Length - 1 - i] + overflow;
                res.Add(n % 10);
                overflow = n / 10;
            }

            if (overflow > 0) {
                res.Add(overflow);
            }

            res.Reverse();
            return res.ToArray();
        }
    }
}
