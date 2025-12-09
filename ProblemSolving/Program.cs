// See https://aka.ms/new-console-template for more information
using ProblemSolving;
using ProblemSolving.Solutions.Q_5;

Console.WriteLine("Hello, World!");

LongestPalindrome longestPalindrome = new LongestPalindrome();
//LongestPalindrome_Wrong longestPalindrome = new LongestPalindrome_Wrong();
//string result = longestPalindrome.Run("babad");
//string result = longestPalindrome.Run("cbbd");
string result = longestPalindrome.Run("ccc");
Console.WriteLine(result);
//_1TwoSum twoSum = new _1TwoSum();
//twoSum.Run();

/*  Input: l1 = [2,4,3], l2 = [5,6,4]
    Output: [7,0,8]
    Explanation: 342 + 465 = 807.
    Example 2:
 */

//ListNode l1 = new ListNode()
//{
//    val=2,
//    next = new ListNode()
//    {
//        val = 4,
//        next = new ListNode()
//        {
//            val = 3,
//            next = null
//        }
//    }
//};

//ListNode l2 = new ListNode()
//{
//    val = 5,
//    next = new ListNode()
//    {
//        val = 6,
//        next = new ListNode()
//        {
//            val = 4,
//            next = null
//        }
//    }
//};

//_2AddTwoNumbers _2AddTwoNumbers = new _2AddTwoNumbers();
//ListNode result = _2AddTwoNumbers.AddTwoNumbers(l1 , l2);

//while(result != null)
//{
//    Console.WriteLine(result.val);
//    result = result.next;
//}