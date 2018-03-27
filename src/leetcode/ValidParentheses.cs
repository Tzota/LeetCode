using System;
using System.Collections.Generic;

namespace leetcode
{
    /// <summary>
    /// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    /// The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
    /// </summary>
    public class ValidParentheses
    {
        private static Dictionary<char, char> pairs = new Dictionary<char, char>() {
            {'(', ')'},
            {'[', ']'},
            {'{', '}'},
        };

        public bool IsValid(string s) {
            if (string.IsNullOrEmpty(s)) {
                return true;
            }

            char[] chars = s.ToCharArray();
            var stack = new Stack<char>();
            foreach (var sign in chars)
            {
                if (pairs.ContainsKey(sign))
                {
                    stack.Push(sign);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char c = stack.Pop();
                    if (pairs[c] != sign)
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
