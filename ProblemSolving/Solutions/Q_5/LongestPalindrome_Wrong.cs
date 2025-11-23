using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Solutions.Q_5
{
    public class LongestPalindrome_Wrong
    {
        //Wrong Answer
        public string Run(string s)
        {
            //ccc
            int pointer = 0, traversal = 1;
            int[] substring = new int[2];
            if(s.Length <= 1)
            {
                return s;
            }
            if(s.Length == 2 && s[0] != s[1])
            {
                return s.Substring(0, 1);
            }
            while (pointer < s.Length-1)
            {
                if (substring[0] + substring[1] < traversal - pointer)
                {
                    if(pointer-traversal+1  <= 3)
                    {
                        if (s[pointer] == s[traversal])
                        {
                            substring[0] = pointer;
                            substring[1] = traversal;
                        }
                    }
                    else
                    {
                        string temp = s.Substring(pointer,traversal);
                        if(temp == temp.Reverse().ToString())
                        {
                            substring[0] = pointer;
                            substring[1] = traversal;
                        }
                    }
                }
                if (traversal == s.Length-1)
                {
                    pointer++;
                    traversal = pointer + 1;
                    continue;
                }
                else
                {
                    traversal++;
                }
            }
            return s.Substring(substring[0], substring[1]);
        }
    }
}
