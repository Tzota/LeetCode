using System;
using System.Linq;

namespace leetcode
{
    /// <summary>
    /// 14. Longest Common Prefix
    /// Write a function to find the longest common prefix string amongst an array of strings.
    /// </summary>
    public class LongestCommonPrefix
    {
        public string Find(string[] strs)
        {
            return Naive(strs);
        }

        public string Naive(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            int len = 1;

            while(true)
            {
                string prev = strs[0].Substring(0, len - 1);

                if (strs[0].Length < len)
                {
                    return prev;
                }

                string pattern = strs[0].Substring(0, len);

                foreach(string s in strs)
                {
                    // очередная строка оказалась слишком короткой
                    if (s.Length < len)
                    {
                        return prev;
                    }

                    // очередная строка не содержит общий префикс
                    if (s.Substring(0, len) != pattern)
                    {
                        return prev;
                    }
                }
                len++;
            }
        }
    }
}
