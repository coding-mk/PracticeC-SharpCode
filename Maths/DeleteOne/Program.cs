//Delete one
/*Problem Description

You are given an integer array A of size N. You must remove exactly one element. Return the maximum possible gcd of the remaining N - 1 elements.


Problem Constraints

2 <= N <= 105
1 <= A[i] <= 109


Input Format

The only argument is the integer array A.


Output Format

Return a single integer, the maximum gcd after removing one element.


Example Input

Input 1:
A = [12, 15, 18]
Input 2:
A = [5, 15, 30]


Example Output

Output 1:
6
Output 2:
15


Example Explanation

Explanation 1:
Remove 12 -> gcd(15, 18) = 3.
Remove 15 -> gcd(12, 18) = 6.
Remove 18 -> gcd(12, 15) = 3.
Best is 6.
Explanation 2:
Remove 5  -> gcd(15, 30) = 15.
Remove 15 -> gcd(5, 30)  = 5.
Remove 30 -> gcd(5, 15)  = 5.
Best is 15.
 */

namespace DeleteOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> A = new List<int>() { 12, 15, 18 };
            int result = solve(A);
            Console.WriteLine(result);
            List<int> B = new List<int>() { 5, 15, 30 };
            int result2 = solve(B);
            Console.WriteLine(result2);
        }

        public static int solve(List<int> A)
        {
            List<int> sf = new List<int>();
            List<int> pf = new List<int>();
            pf.Add(A[0]);
            sf.Add(A[A.Count() - 1]);
            for (int a = 1; a < A.Count(); a++)
            {
                pf.Add(Gcd(pf[a - 1], A[a]));
            }
            int k = 0;
            for (int a = A.Count() - 2; a >= 0; a--)
            {
                sf.Add(Gcd(sf[k], A[a]));
                k += 1;
            }
            int i = 0, j = pf.Count() - 1, temp = 0;
            while (i < j)
            {
                temp = pf[i];
                pf[i] = pf[j];
                pf[j] = temp;
                i++;
                j--;
            }
            int max = pf[0];
            for (int m = 1; m < A.Count() - 1; m++)
            {
                max = Math.Max(max, Gcd(sf[m - 1], pf[m + 1]));
            }
            max = Math.Max(max, sf[sf.Count() - 2]);

            return (max);
        }

        public static int Gcd(int A, int B)
        {
            if (B == 0)
            {
                return (A);
            }
            return (Gcd(B, A % B));
        }
    }
}