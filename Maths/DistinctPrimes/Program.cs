//Distinct Primes
/*You have given an array A having N integers. Let say G is the product of all elements of A.

You have to find the number of distinct prime divisors of G.



Input Format

The first argument given is an Array A, having N integers.
Output Format

Return an Integer, i.e number of distinct prime divisors of G.
Constraints

1 <= N <= 1e5
1 <= A[i] <= 1e5
For Example

Input:
    A = [1, 2, 3, 4]
Output:
     2

Explanation:
    here G = 1 * 2 * 3 * 4 = 24
    and distinct prime divisors of G are [2, 3]
 */
namespace DistinctPrimes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4 };
            int result = Solve(A);
            Console.WriteLine(result);
        }

        public static int Solve(int[] A)
        {
            int max = int.MinValue;
            foreach (int j in A)
            {
                if (max < j)
                {
                    max = j;
                }
            }
            int[] spf = new int[max + 1];
            for (int i = 0; i <= max; i++)
            {
                spf[i] = i;
            }
            for (int i = 2; i * i <= max; i++)
            {
                if (spf[i] == i)
                {
                    for (int j = i * i; j <= max; j = j + i)
                    {
                        if (spf[j] == j)
                        {
                            spf[j] = i;
                        }
                    }
                }
            }

            HashSet<int> primefact = new HashSet<int>();
            int p = 0;
            foreach (int num in A)
            {
                p = 0;
                int n = num;
                while (n > 1)
                {
                    p = spf[n];
                    primefact.Add(p);
                    n = n / p;
                }
            }
            return (primefact.Count);
        }
    }
}