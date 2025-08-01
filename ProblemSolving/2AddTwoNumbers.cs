﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class _2AddTwoNumbers
    {
        /*You are given two non-empty linked lists representing two non-negative integers. 
         * The digits are stored in reverse order, and each of their nodes contains a single digit. 
         * Add the two numbers and return the sum as a linked list.
         * You may assume the two numbers do not contain any leading zero, 
         * except the number 0 itself.
         * Input: l1 = [2,4,3], l2 = [5,6,4]
            Output: [7,0,8]
            Explanation: 342 + 465 = 807.
            Example 2:

            Input: l1 = [0], l2 = [0]
            Output: [0]
            Example 3:

            Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
            Output: [8,9,9,9,0,0,0,1]
         */

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode current = result;
            int carry = 0;
            while (l1 != null || l2 !=null)
            {
                int x = l1?.val ?? 0;
                int y = l2?.val ?? 0;
                int sum = x + y;
                if (carry != 0)
                {
                    sum += carry;
                    carry = 0;
                }
                current.next = new ListNode(sum % 10);
                current = current.next;
                carry = sum / 10;
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if(l2 != null)
                {
                    l2 = l2.next;
                }
            }
            if (carry != 0)
            {
                current.next = new ListNode(carry);
            }

            return result.next;
        }
    }
}
