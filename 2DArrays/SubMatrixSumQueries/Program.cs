//Sub-matrix Sum Queries
/*
Problem Description

Given a matrix of integers A of size N x M and multiple queries Q, for each query, find and return the submatrix sum.




Inputs to queries are top left (b, c) and bottom right (d, e) indexes of submatrix whose sum is to find out.

NOTE:

Rows are numbered from top to bottom, and columns are numbered from left to right.
The sum may be large, so return the answer mod 109 + 7.
Also, select the data type carefully, if you want to store the addition of some elements.
Indexing given in B, C, D, and E arrays is 1-based.
Top Left 0-based index = (B[i] - 1, C[i] - 1)
Bottom Right 0-based index = (D[i] - 1, E[i] - 1)




Problem Constraints

1 <= N, M <= 1000
-100000 <= A[i] <= 100000
1 <= Q <= 100000
1 <= B[i] <= D[i] <= N
1 <= C[i] <= E[i] <= M



Input Format

The first argument given is the integer matrix A.
The second argument given is the integer array B.
The third argument given is the integer array C.
The fourth argument given is the integer array D.
The fifth argument given is the integer array E.
(B[i], C[i]) represents the top left corner of the i'th query.
(D[i], E[i]) represents the bottom right corner of the i'th query.



Output Format

Return an integer array containing the submatrix sum for each query.



Example Input

Input 1:

 A = [   [1, 2, 3]
         [4, 5, 6]
         [7, 8, 9]   ]
 B = [1, 2]
 C = [1, 2]
 D = [2, 3]
 E = [2, 3]
Input 2:

 A = [   [5, 17, 100, 11]
         [0, 0,  2,   8]    ]
 B = [1, 1]
 C = [1, 4]
 D = [2, 2]
 E = [2, 4]


Example Output

Output 1:

 [12, 28]
Output 2:

 [22, 19]


Example Explanation

Explanation 1:

 For query 1: Submatrix contains elements: 1, 2, 4 and 5. So, their sum is 12.
 For query 2: Submatrix contains elements: 5, 6, 8 and 9. So, their sum is 28.
Explanation 2:

 For query 1: Submatrix contains elements: 5, 17, 0 and 0. So, their sum is 22.
 For query 2: Submatrix contains elements: 11 and 8. So, their sum is 19. */
namespace SubMatrixSumQueries
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int[][] A = new int[][]{
      new int[] { 1,2,3 },
      new int[] { 4,5,6 },
      new int[] { 7,8,9 }};
      int[] B = new int[] { 1, 2 };
      int[] C = new int[] { 1, 2 };
      int[] D = new int[] { 2, 3 };
      int[] E = new int[] { 2, 3 };

      var ans = Solve(A, B, C, D, E);
      foreach (var i in ans)
      {
        Console.Write($"{i} ");
      }
    }

    public static int[] Solve(int[][] A, int[] B, int[] C, int[] D, int[] E)
    {
      int N = A.Count(), M = A[0].Count();
      int mod = 1000000007;
      long[,] pfmat = new long[N, M];
      for (int i = 0; i < N; i++)
      {
        pfmat[i, 0] = (long)A[i][0];
      }
      for (int i = 0; i < N; i++)
      {
        for (int j = 1; j < M; j++)
        {
          pfmat[i, j] = (pfmat[i, j - 1] + (long)A[i][j]) % mod;
        }
      }
      for (int i = 0; i < M; i++)
      {
        for (int j = 1; j < N; j++)
        {
          pfmat[j, i] = (pfmat[j - 1, i] + pfmat[j, i]) % mod;
        }
      }
      int a1 = 0, b1 = 0, a2 = 0, b2 = 0, n = B.Count();
      long sum = 0;
      int[] ans = new int[n];
      for (int i = 0; i < n; i++)
      {
        a1 = B[i] - 1;
        b1 = C[i] - 1;
        a2 = D[i] - 1;
        b2 = E[i] - 1;
        sum = pfmat[a2, b2];
        if (a1 > 0)
        {
          sum = sum - pfmat[a1 - 1, b2];
        }
        if (b1 > 0)
        {
          sum = sum - pfmat[a2, b1 - 1];
        }
        if (a1 > 0 && b1 > 0)
        {
          sum = sum + pfmat[a1 - 1, b1 - 1];
        }
        sum %= mod;
        while (sum < 0)
          sum += mod;
        ans[i] = (int)sum;
      }
      return (ans);
    }

  }
}
