//Count Total Set Bits
/*Problem Description

Given a positive integer A, the task is to count the total number of set bits in the binary representation of all the numbers from 1 to A.

Return the count modulo 109 + 7.



Problem Constraints

1 <= A <= 109



Input Format

First and only argument is an integer A.



Output Format

Return an integer denoting the ( Total number of set bits in the binary representation of all the numbers from 1 to A )modulo 109 + 7.



Example Input

Input 1:

 A = 3
Input 2:

 A = 1


Example Output

Output 1:

 4
Output 2:

 1


Example Explanation

Explanation 1:

 DECIMAL    BINARY  SET BIT COUNT
    1          01        1
    2          10        1
    3          11        2
 1 + 1 + 2 = 4 
 Answer = 4 % 1000000007 = 4
Explanation 2:

 A = 1
  DECIMAL    BINARY  SET BIT COUNT
    1          01        1
 Answer = 1 % 1000000007 = 1
 */
namespace CountTotalSetBits
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CountSetBits(3));
            Console.WriteLine(CountSetBits(1));
        }

        public static int CountSetBits(int value)
        {
            long N = value + 1, mod = 1000 * 1000 * 1000 + 7;
            long ans = 0, pow2 = 1;
            for (int i = 0; i < 32; i++)
            {
                ans += ((N / (pow2 << 1)) * pow2) % mod + Math.Max(0, N % (pow2 << 1) - pow2);
                ans %= mod;
                pow2 <<= 1;
            }
            return (int)ans;
        }
    }
}