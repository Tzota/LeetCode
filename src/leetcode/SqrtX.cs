using System;
using System.Collections.Generic;

namespace leetcode
{

    /// <summary>
    /// 69. Sqrt(x)
    /// Implement int sqrt(int x).
    /// Compute and return the square root of x, where x is guaranteed to be a non-negative integer.
    /// Since the return type is an integer, the decimal digits are truncated and only the integer part of the result is returned.
    /// </summary>
    public class SqrtX
    {
        public int MySqrt(int x) {
            if (x <= 1)
            {
                return x;
            }

            Func<double, int> I = a => Convert.ToInt32(Math.Floor(a));

            double prev = 0;
            double curr = x / 2;
            int oops = 0;
            while(I(prev) != I(curr)) {
                prev = curr;
                curr = 0.5 *(curr + x/curr);
                if (oops++ == 100) throw new Exception("oops");
            }
            return I(curr);
        }
    }
}
