//Rearrange Array
/*Given an array A of size N. Rearrange the given array so that A[i] becomes A[A[i]] with O(1) extra space.

Constraints:

1 <= N <= 5×104

0 <= A[i] <= N - 1

The elements of A are distinct

Input Format

The argument A is an array of integers

Example 1:

Input : [1, 0]
Return : [0, 1]
Example 2:

Input : [0, 2, 1, 3]
Return : [0, 1, 2, 3]
 */
namespace RearrangeArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> A = new List<int>() { 1, 0 };
            List<int> B = new List<int>() { 0, 2, 1, 3 };
            Arrange(A);
            Console.WriteLine();
            Arrange(B);

        }

        public static void Arrange(List<int> A)
        {
            int n = A.Count();
            for (int i = 0; i < n; i++) A[i] = A[i] + (A[A[i]] % n) * n;
            for (int i = 0; i < n; i++) A[i] = A[i] / n;
            foreach (var item in A)
            {
                Console.Write($"{item} ");
            }
        }
    }
}