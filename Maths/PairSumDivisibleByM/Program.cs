//Pair Sum divisible by M
/*Problem Description

Given an array of integers A and an integer B, find and return the number of pairs in A whose sum is divisible by B.

Since the answer may be large, return the answer modulo (109 + 7).

Note: Ensure to handle integer overflow when performing the calculations.


Problem Constraints

1 <= length of the array <= 100000
1 <= A[i] <= 109
1 <= B <= 106



Input Format

The first argument given is the integer array A.
The second argument given is the integer B.



Output Format

Return the total number of pairs for which the sum is divisible by B modulo (109 + 7).



Example Input

Input 1:

 A = [1, 2, 3, 4, 5]
 B = 2
Input 2:

 A = [5, 17, 100, 11]
 B = 28


Example Output

Output 1:

 4
Output 2:

 1


Example Explanation

Explanation 1:
 All pairs which are divisible by 2 are (1,3), (1,5), (2,4), (3,5). 
 So total 4 pairs.
Explanation 2:
 There is only one pair which is divisible by 28 is (17, 11)
 */
namespace PairSumDivisibleByM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5 };
            int B = 2;
            int result = Solve(A, B);
            Console.WriteLine(result); // Output: 4
            int[] A2 = { 5, 17, 100, 11 };
            int B2 = 28;
            int result2 = Solve(A2, B2);
            Console.WriteLine(result2); // Output: 1
        }

        public static int Solve(int[] a, int k)
        {
            int n = a.Length;
            long mod = (long)(1e9 + 7);
            long[] cnt = new long[k];
            // cnt[i] stores the count of elements such that their modulo k equals i
            foreach (int x in a) cnt[x % k]++;
            long ans = cnt[0] * (cnt[0] - 1) / 2;
            for (int i = 1, j = k - 1; i <= j; i++, j--)
            {
                if (i == j)
                    ans = (ans + cnt[i] * (cnt[i] - 1) / 2) % mod;
                else
                    ans = (ans + cnt[i] * cnt[j]) % mod;
            }
            return (int)ans;
        }
    }
}