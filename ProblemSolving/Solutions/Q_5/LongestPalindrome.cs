using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Solutions.Q_5
{
    public class LongestPalindrome
    {
        /*          * Given a string s, return the longest palindromic substring in s.
         * A string is called a palindrome string if the reverse of that string is the same as the original string.
         * 
         * Example 1:
         * Input: s = "babad"
         * Output: "bab"
         * Explanation: "aba" is also a valid answer.
         * 
         * Example 2:
         * Input: s = "cbbd"
         * Output: "bb"
         * 
         * Constraints:
         * 1 <= s.length <= 1000
         * s consist of only digits and English letters (lower-case and/or upper-case),
         * 
         * Algorithm: 
         * gather all substrings and check if they are palindrome, keep track of the longest one found
         * Rumtime: 1530Ms
         * Memory: 57.30MB
         */

        public string Run(string s)
        {
            int pointer = 0, traversal = 1;
            string longestPalindrome = s.Substring(0, 1);
            if (s.Length <= 1)
            {
                return s;
            } 

            while (pointer < s.Length)
            {
                while (traversal <= s.Length)
                {
                    string substring = s.Substring(pointer, traversal - pointer);
                    if (IsPalindrome(substring) && substring.Length > longestPalindrome.Length)
                    {
                        longestPalindrome = substring;
                    }
                    traversal++;
                }
                pointer++;
                traversal = pointer + 1;
            }
            return longestPalindrome;
        }

        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
