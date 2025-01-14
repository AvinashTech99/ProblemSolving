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
            int[] nums = [2, 7, 13, 15];
            int target = 20;
            //int[] res = Logic(nums, target);
            int[] res = logic1(nums, target);
            Console.WriteLine($"[{res[0]} {res[1]}]");
        }
        public int[] Logic(int[] nums, int target)
        {
            int[] indices = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length - i; j++)
                {
                    if (nums[i] < target && nums[j] < target && nums[i] != nums[j])
                    {
                        int num1 = nums[i];
                        int num2 = nums[j];
                        if (num1 + num2 == target)
                        {
                            indices[0] = num1;
                            indices[1] = num2;
                            return indices;
                        }
                    }
                }
            }

            return indices;
        }

        public int[] logic1(int[] nums, int target)
        {
            Dictionary<int, int> indices = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < target)
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
            }
            return new int[2];
        }
    }
}
