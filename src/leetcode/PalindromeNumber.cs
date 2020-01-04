using System;

namespace leetcode
{
    /// <summary>
    /// Determines whether an integer is a palindrome.
    /// </summary>
    public class PalindromeNumber
    {
        public bool Execute(int x)
        {
            // if (x < 0) return false;
            // if (x == 0) return true;

            // return x == (new ReverseInteger()).Execute(x);

            if ( x < 0 || (x!=0 && x%10==0) ) {
                return false;
            }

            int sum=0;
            while(x>sum)
            {
                sum = sum*10+x%10;
                x = x/10;
            }
            return (x==sum)||(x==sum/10);
        }
    }
}