//Matrix Multiplication
/*Problem Description
You are given two integer matrices A(having M X N size) and B(having N X P). You have to multiply matrix A with B and return the resultant matrix. (i.e. return the matrix AB).
Matrix Multiplication

Problem Constraints:
1 <= M, N, P <= 100
-100 <= A[i][j], B[i][j] <= 100

Input Format:
The first argument given is the 2-D integer matrix A.
The second argument given is the 2-D integer matrix B.

Output Format:
Return a 2D integer matrix denoting AB.

Example Input:
Input 1:
A = [[1, 2],
     [3, 4]]
B = [[5, 6],
     [7, 8]]
Input 2:
A = [[1, 1]]
B = [[2],
     [3]]

Example Output:
Output 1:
 [[19, 22],
  [43, 50]]
Output 2:
 [[5]]
 */
namespace MatrixMultiplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<List<int>> A = new List<List<int>>
      {
          new List<int> { 1, 2 },
          new List<int> { 3, 4 }
      };

      List<List<int>> B = new List<List<int>>
      {
          new List<int> { 5, 6 },
          new List<int> { 7, 8 }
      };

      A = Solve(A, B);
      for (int i = 0; i < A.Count(); i++)
      {
        for (int j = 0; j < A[0].Count(); j++)
        {
          Console.Write($"{A[i][j]}  ");
        }
        Console.WriteLine("");
      }
    }

    public static List<List<int>> Solve(List<List<int>> A, List<List<int>> B)
    {
      List<List<int>> mulMatrix = new List<List<int>>();
      List<int> row = new List<int>();
      int sum = 0;
      for (int i = 0; i < A.Count(); i++)
      {
        row = new List<int>();
        for (int j = 0; j < B[0].Count(); j++)
        {
          sum = 0;
          for (int k = 0; k < A[0].Count(); k++)
          {
            sum += A[i][k] * B[k][j];
          }
          row.Add(sum);
        }
        mulMatrix.Add(row);
      }
      return (mulMatrix);
    }
  }
}