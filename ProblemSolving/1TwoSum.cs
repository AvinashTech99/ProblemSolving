using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the 
    /// two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, 
    /// and you may not use the same element twice.
    /// You can return the answer in any order.
    /// Input: nums = [2,7,11,15], target = 9
    /// Output: [0, 1]
    /// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    /// </summary>
    internal class _1TwoSum
    {
        public void Run()
        {
            //int[] nums = [2, 7, 11, 15];
            //int target = 9;
            int[] nums = [-3, 4, 3, 90];
            int target = 0;
            //int[] res = Logic(nums, target);
            int[] res = logic1(nums, target);
            Console.WriteLine($"[{res[0]} {res[1]}]");
        }
        public int[] logic1(int[] nums, int target) //Time 1MS for 68 test cases
        {
            Dictionary<int, int> indices = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (indices.ContainsKey(complement))
                {
                    return new int[] { indices[complement], i };
                }
                if (!indices.ContainsKey(nums[i]))
                {
                    indices.Add(nums[i], i);
                }
            }
            return new int[2];
        }
    }
}
