//Matrix Subtraction
/*Problem Description
You are given two integer matrices A and B having same size(Both having same number of rows (N) and columns (M). You have to subtract matrix B from A and return the resultant matrix. (i.e. return the matrix A - B).
If A and B are two matrices of the same order (same dimensions). Then A - B is a matrix of the same order as A and B and its elements are obtained by doing an element wise subtraction of A from B.

Problem Constraints:
1 <= N, M <= 103
-109 <= A[i][j], B[i][j] <= 109

Input Format:
The first argument is the 2D integer array A
The second argument is the 2D integer array B

Output Format:
Return a 2D matrix denoting A - B.

Example Input:
Input 1:
A =  [[1, 2, 3], 
      [4, 5, 6], 
      [7, 8, 9]]

B =  [[9, 8, 7], 
      [6, 5, 4], 
      [3, 2, 1]]
Input 2:
A = [[1, 1]] 
B = [[2, 3]] 

Example Output:
Output 1:
 [[-8, -6, -4],
  [-2, 0, 2],
  [4, 6, 8]]
Output 2:
 [[-1, -2]]

Example Explanation
Explanation 1:
Explanation 2:
 [[1, 1]] - [[2, 3]] = [[1 - 2, 1 - 3]] = [[-1, -2]]
*/
namespace MatrixSubtraction
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<List<int>> A = new List<List<int>>
      {
          new List<int> { 1, 2, 3 },
          new List<int> { 4, 5, 6 },
          new List<int> { 7, 8, 9 },
      };

      List<List<int>> B = new List<List<int>>
      {
          new List<int> { 9, 8, 7 },
          new List<int> { 6, 5, 4 },
          new List<int> { 3, 2, 1 },
      };

      A = solve(A, B);
      for (int i = 0; i < A.Count(); i++)
      {
        for (int j = 0; j < A[0].Count(); j++)
        {
          Console.Write($"{A[i][j]}  ");
        }
        Console.WriteLine("");
      }
    }

    public static List<List<int>> solve(List<List<int>> A, List<List<int>> B)
    {
      for (int i = 0; i < A.Count(); i++)
      {
        for (int j = 0; j < A[0].Count(); j++)
        {
          A[i][j] = A[i][j] - B[i][j];
        }
      }
      return A;
    }
  }
}