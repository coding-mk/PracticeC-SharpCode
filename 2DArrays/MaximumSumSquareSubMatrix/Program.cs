//Maximum Sum Square SubMatrix
/*Problem Description

Given a 2D integer matrix A of size N x N, find a B x B submatrix where B<= N and B>= 1, such that the sum of all the elements in the submatrix is maximum.



Problem Constraints

1 <= N <= 103.

1 <= B <= N

-102 <= A[i][j] <= 102.



Input Format

First arguement is an 2D integer matrix A.

Second argument is an integer B.



Output Format

Return a single integer denoting the maximum sum of submatrix of size B x B.



Example Input

Input 1:

 A = [
        [1, 1, 1, 1, 1]
        [2, 2, 2, 2, 2]
        [3, 8, 6, 7, 3]
        [4, 4, 4, 4, 4]
        [5, 5, 5, 5, 5]
     ]
 B = 3
Input 2:

 A = [
        [2, 2]
        [2, 2]
    ]
 B = 2


Example Output

Output 1:

 48
Output 2:

 8


Example Explanation

Explanation 1:

    Maximum sum 3 x 3 matrix is
    8 6 7
    4 4 4
    5 5 5
    Sum = 48
Explanation 2:

 Maximum sum 2 x 2 matrix is
  2 2
  2 2
  Sum = 8
 */
namespace MaximumSumSquareSubMatrix
{
  public class Program
  {
    static int maxn = 1009;
    static int[,] stripSum = new int[maxn, maxn];
    public static void Main(string[] args)
    {
      int[][] A = new int[][]{
      new int[] {1, 1, 1, 1, 1},
      new int[] {2, 2, 2, 2, 2},
      new int[] {3, 8, 6, 7, 3},
      new int[] {4, 4, 4, 4, 4},
      new int[] {5, 5, 5, 5, 5}};
      int B = 3;
      Console.WriteLine(Solve(A, B));
    }

    public static void GetStripSum(int[][] A, int B)
    {
      int N = A.Count();
      // To store sums of all strips of size B x 1
      for (int i = 0; i < maxn; i++)
        for (int j = 0; j < maxn; j++)
          stripSum[i, j] = 0;

      // Go column by column
      for (int j = 0; j < N; j++)
      {
        // Calculate sum of first B x 1 rectangle in this column
        int sum = 0;
        for (int i = 0; i < B; i++)
          sum += A[i][j];
        stripSum[0, j] = sum;

        // Calculate sum of remaining rectangles
        for (int i = 1; i < N - B + 1; i++)
        {
          sum += (A[i + B - 1][j] - A[i - 1][j]);
          stripSum[i, j] = sum;
        }
      }
    }
    public static int Solve(int[][] A, int B)
    {
      int N = A.Count();
      // B must be smaller than or equal to N
      if (B > N) return 0;

      // 1: PREPROCESSING
      GetStripSum(A, B);

      // max_sum stores maximum sum in matrix
      int max_sum = int.MinValue;

      // 2: CALCULATE SUM of Sub-Squares using stripSum[][]
      for (int i = 0; i < N - B + 1; i++)
      {
        // Calculate sum of first subsquare in this row
        int sum = 0;
        for (int j = 0; j < B; j++)
          sum += stripSum[i, j];

        // Update max_sum
        if (sum > max_sum)
        {
          max_sum = sum;
        }

        // Calculate sum of remaining squares in current row by removing
        // the leftmost strip of previous sub-square and adding a new strip
        for (int j = 1; j < N - B + 1; j++)
        {
          sum += (stripSum[i, j + B - 1] - stripSum[i, j - 1]);
          // Update max_sum
          if (sum > max_sum)
          {
            max_sum = sum;
          }
        }
      }
      return max_sum;
    }
  }
}