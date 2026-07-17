//Single Number II
/*Problem Description

Given an array of integers, every element appears thrice except for one, which occurs once.

Find that element that does not appear thrice.

NOTE: Your algorithm should have a linear runtime complexity.

Could you implement it without using extra memory?




Problem Constraints

2 <= |A| <= 5*106

0 <= A[i] <= INTMAX



Input Format

First and only argument of input contains an integer array A.



Output Format

Return a single integer.



Example Input

Input 1:

 A = [1, 2, 4, 3, 3, 2, 2, 3, 1, 1]
Input 2:

 A = [0, 0, 0, 1]


Example Output

Output 1:

 4
Output 2:

 1


Example Explanation

Explanation 1:

 4 occurs exactly once in Input 1.
 1 occurs exactly once in Input 2.
 */
namespace SingleNumberII
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 4, 3, 3, 2, 2, 3, 1, 1 };
            int result = SingleNumber(A);
            Console.WriteLine(result);
            int[] B = new int[] { 0, 0, 0, 1 };
            int result2 = SingleNumber(B);
            Console.WriteLine(result2);
        }

        public static int SingleNumber(int[] A)
        {
            int[] bitCount = new int[32];
            foreach (int num in A)
            {
                for (int i = 0; i < 32; i++)
                {
                    bitCount[i] += (1 & (num >> i));
                    bitCount[i] %= 3;
                }
            }
            int result = 0;
            for (int i = 31; i >= 0; i--)
            {
                result = result * 2 + bitCount[i];
            }
            return result;
        }

    }
}