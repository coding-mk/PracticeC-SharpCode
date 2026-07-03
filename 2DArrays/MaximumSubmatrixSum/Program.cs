//Maximum Submatrix Sum
/*Problem Description
Given a row-wise and column-wise sorted matrix A of size N * M.
Return the maximum non-empty submatrix sum of this matrix.

Problem Constraints
1 <= N, M <= 1000
-109 <= A[i][j] <= 109

Input Format
The first argument is a 2D integer array A.

Output Format
Return a single integer that is the maximum non-empty submatrix sum of this matrix.

Example Input

Input 1:-
    -5 -4 -3
A = -1  2  3
     2  2  4
Input 2:-
    1 2 3
A = 4 5 6
    7 8 9


Example Output

Output 1:-
12
Output 2:-
45


Example Explanation

Expanation 1:-
The submatrix with max sum is 
-1 2 3
 2 2 4
 Sum is 12.
Explanation 2:-
The largest submatrix with max sum is 
1 2 3
4 5 6
7 8 9
The sum is 45.
 */
namespace MaximumSubmatrixSum
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int[][] A = new int[][]{
      new int[] { -5, -4, -3 },
      new int[] { -1, 2, 3 },
      new int[] { 2, 2, 4 }};
      Console.WriteLine(Solve(A));
    }

    public static long Solve(int[][] A)
    {
      int n = A.Length;
      int m = A[0].Length;

      long[,] suff = new long[n, m];

      suff[n - 1, m - 1] = A[n - 1][m - 1];
      long ans = suff[n - 1, m - 1];

      // Last row
      for (int j = m - 2; j >= 0; j--)
      {
        suff[n - 1, j] = suff[n - 1, j + 1] + A[n - 1][j];
        ans = Math.Max(ans, suff[n - 1, j]);
      }

      // Last column
      for (int i = n - 2; i >= 0; i--)
      {
        suff[i, m - 1] = suff[i + 1, m - 1] + A[i][m - 1];
        ans = Math.Max(ans, suff[i, m - 1]);
      }

      // Remaining cells
      for (int i = n - 2; i >= 0; i--)
      {
        for (int j = m - 2; j >= 0; j--)
        {
          suff[i, j] = A[i][j]
                     + suff[i + 1, j]
                     + suff[i, j + 1]
                     - suff[i + 1, j + 1];

          ans = Math.Max(ans, suff[i, j]);
        }
      }

      return ans;
    }
  }
}
