//Divisibility by 8
/*Problem Description

You are given a number A in the form of a string. Check if the number is divisible by eight or not.

Return 1 if it is divisible by eight else, return 0.


Problem Constraints

1 <= length of the String <= 100000
'0' <= A[i] <= '9'


Input Format

The only argument given is a string A.


Output Format

Return 1 if it is divisible by eight else return 0.


Example Input

Input 1:
A = "16"
Input 2:

A = "123"


Example Output

Output 1:
1
Output 2:

0


Example Explanation

Explanation 1:
 16 = 8 * 2
Explanation 2:

123 = 15 * 8 + 3
 */
namespace DivisibilityBy8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Solve("16"));
            Console.WriteLine(Solve("123"));
        }

        public static int Solve(string A)
        {
            int l = A.Count() - 1, n = 1, sum = 0, i = 0, c = 0;
            while (l >= 0 && i < 3)
            {
                c = int.Parse(A[l].ToString());
                sum = sum + (c * n);
                n = n * 10;
                l -= 1;
                i += 1;
            }
            if (sum % 8 == 0)
            {
                return (1);
            }
            else
            {
                return (0);
            }
        }
    }
}