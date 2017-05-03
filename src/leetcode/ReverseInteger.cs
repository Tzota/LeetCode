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
        /// <param name="num"></param>
        /// <returns></returns>
        public int Execute(int num)
        {
            int res = 0;

            while(num != 0)
            {
                int r = num % 10;

                try
                {
                    // Нет, можно, конечно, просто смену знака смотреть...
                    res = checked(res * 10 + r);
                }
                catch (System.OverflowException e)
                {
                    return 0;
                }

                num = num / 10;
            }

            return res;
        }
    }
}