using System;
using System.Text;

namespace leetcode
{
    /// <summary>
    /// The count-and-say sequence is the sequence of integers with the first five terms as following:
    /// 1.     1
    /// 2.     11
    /// 3.     21
    /// 4.     1211
    /// 5.     111221
    ///
    /// 1 is read off as "one 1" or 11.
    /// 11 is read off as "two 1s" or 21.
    /// 21 is read off as "one 2, then one 1" or 1211.
    ///
    /// Given an integer n, generate the nth term of the count-and-say sequence.
    /// Note: Each term of the sequence of integers will be represented as a string.
    ///
    /// Example 1:
    /// Input: 1
    /// Output: "1"
    ///
    /// Example 2:
    /// Input: 4
    /// Output: "1211"
    /// </summary>
    public class CountandSay
    {
        public string CountAndSay(int n) {
            if(n == 1) {
                return "1";
            }
            var str = CountAndSay(n-1);

            var res = new StringBuilder();
            char current = str[0];
            int counter = 1;
            for(int i = 1; i < str.Length; i++)
            {
                if (current == str[i])
                {
                    counter++;
                }
                else
                {
                    res.Append(counter);
                    res.Append(current);
                    current = str[i];
                    counter = 1;
                }
            }
            res.Append(counter);
            res.Append(current);
            return res.ToString();
        }
    }
}
