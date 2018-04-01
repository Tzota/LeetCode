
namespace leetcode
{
    /// <summary>
    /// Implement strStr().
    /// Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
    /// </summary>
    public class ImplementstrStr
    {
        public int StrStr(string haystack, string needle) {
            for(int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                bool flag = true;
                for(int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
