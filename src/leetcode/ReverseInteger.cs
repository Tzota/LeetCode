using System;

namespace leetcode
{
    /// <summary>
    /// Reverse digits of an integer.
    /// Example1: x = 123, return 321
    /// Example2: x = -123, return -321
    /// </summary>
    public class ReverseInteger
    {
        /// <summary>
        /// Reverse digits of an integer.
        /// </summary>
        /// <param name="x"></param>
        /// <returns>reversed int</returns>
        public int Execute(int x)
        {
            return WithChecked(x);
        }

        private int WithChecked(int x)
        {
            int res = 0;

            while(x != 0)
            {
                int r = x % 10;

                try
                {
                    // Нет, можно, конечно, просто смену знака смотреть...
                    res = checked(res * 10 + r);
                }
                catch (System.OverflowException)
                {
                    return 0;
                }
                x = x / 10;
            }

            return res;
        }
    }
}