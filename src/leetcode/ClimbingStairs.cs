using System.Collections.Generic;

namespace leetcode
{
    /// <summary>
    /// You are climbing a stair case. It takes n steps to reach to the top.
    ///
    /// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
    ///
    /// Note: Given n will be a positive integer.
    ///
    /// Example 1:
    ///
    /// Input: 2
    /// Output: 2
    /// Explanation: There are two ways to climb to the top.
    /// 1. 1 step + 1 step
    /// 2. 2 steps
    /// Example 2:
    ///
    /// Input: 3
    /// Output: 3
    /// Explanation: There are three ways to climb to the top.
    /// 1. 1 step + 1 step + 1 step
    /// 2. 1 step + 2 steps
    /// 3. 2 steps + 1 step
    /// </summary>
    public class ClimbingStairs
    {
        public int ClimbStairs(int n) {
            return Calc(n);
        }

        static Dictionary<int, int> memo = new Dictionary<int, int>();

        private static int Calc(int n) {
            if(n == 1) return 1;
            if(n == 2) return 2;

            return MemoOrCalc(n-2) + MemoOrCalc(n-1);
        }

        private static int MemoOrCalc(int n) {
            if(!memo.ContainsKey(n)) {
                memo[n] = Calc(n);
            }

            return memo[n];
        }
    }
}
