using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Q4MedianSortedArrays
{
    public class Solution_4_1
    {
        /*
            4. Median of Two Sorted Arrays
            Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
            
            Example 1:
            Input: nums1 = [1,3], nums2 = [2]
            Output: 2.00000
            Explanation: merged array = [1,2,3] and median is 2.

            Example 2:
            Input: nums1 = [1,2], nums2 = [3,4]
            Output: 2.50000
            Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
         */
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            int length = nums1.Length + nums2.Length;
            int resultAtPos = (length % 2 == 0) ? (length / 2 + 1) : (int)Math.Ceiling((double)length / 2);
            int cursor1 = 0;
            int coursor2 = 0;
            int loop = 0;
            int[] result = new int[resultAtPos];
            while (loop < resultAtPos)
            {
                if ((cursor1 < nums1.Length && coursor2 < nums2.Length && nums1[cursor1] < nums2[coursor2]) || (coursor2 >= nums2.Length && cursor1 < nums1.Length))
                {
                    result[loop] = nums1[cursor1];
                    cursor1++;
                }
                else
                {
                    result[loop] = nums2[coursor2];
                    coursor2++;
                }
                loop++;
            }

            return (length % 2 == 0) ? (double)(result[resultAtPos - 2] + result[resultAtPos - 1]) / 2 : result[resultAtPos - 1];
        }
    }
}
