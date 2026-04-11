//Row To Column Zero
/*Problem Description
You are given a 2D integer matrix A, make all the elements in a row or column zero if the A[i][j] = 0. Specifically, make entire ith row and jth column zero.

Problem Constraints
1 <= A.size() <= 103
1 <= A[i].size() <= 103
0 <= A[i][j] <= 103

Input Format
First argument is a 2D integer matrix A.

Output Format
Return a 2D matrix after doing required operations.

Example Input:
Input 1
[1,2,3,4]
[5,6,7,0]
[9,2,0,4]

Example Output:
Output 1:
[1,2,0,0]
[0,0,0,0]
[0,0,0,0]

Example Explanation:
Explanation 1:
A[2][4] = A[3][3] = 0, so make 2nd row, 3rd row, 3rd column and 4th column zero.
 */
namespace RowToColumnZero
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<List<int>> A = new List<List<int>>
      {
          new List<int> { 1,2,3,4 },
          new List<int> { 5,6,7,0 },
          new List<int> { 9,2,0,4 },
      };

      A = Solve(A);
      for (int i = 0; i < A.Count(); i++)
      {
        for (int j = 0; j < A[0].Count(); j++)
        {
          Console.Write($"{A[i][j]}  ");
        }
        Console.WriteLine("");
      }
    }

    public static List<List<int>> Solve(List<List<int>> A)
    {
      List<int> row = new List<int>();
      List<int> col = new List<int>();
      int R = A.Count();
      int C = A[0].Count();
      for (int i = 0; i < R; i++)
      {
        for (int j = 0; j < C; j++)
        {
          if (A[i][j] == 0)
          {
            row.Add(i);
            col.Add(j);
          }
        }
      }

      foreach (int r in row)
      {
        for (int i = 0; i < C; i++)
        {
          A[r][i] = 0;
        }
      }

      foreach (int c in col)
      {
        for (int i = 0; i < R; i++)
        {
          A[i][c] = 0;
        }
      }

      return (A);
    }
  }
}