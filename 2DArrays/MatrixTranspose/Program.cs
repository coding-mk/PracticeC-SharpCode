//Matrix Transpose
/*Problem Description
Given a 2D integer array A, return the transpose of A.
The transpose of a matrix is the matrix flipped over its main diagonal, switching the matrix's row and column indices.

Problem Constraints:
1 <= A.size() <= 1000
1 <= A[i].size() <= 1000
1 <= A[i][j] <= 1000

Input Format:
First argument is a 2D matrix of integers.

Output Format:
You have to return the Transpose of this 2D matrix.

Example Input:
Input 1:
A = [[1, 2, 3],[4, 5, 6],[7, 8, 9]]
Input 2:
A = [[1, 2],[1, 2],[1, 2]]

Example Output:
Output 1:
[[1, 4, 7], [2, 5, 8], [3, 6, 9]]
Output 2:
[[1, 1, 1], [2, 2, 2]]

Example Explanation:
Explanation 1:
Clearly after converting rows to column and columns to rows of [[1, 2, 3],[4, 5, 6],[7, 8, 9]]
 we will get [[1, 4, 7], [2, 5, 8], [3, 6, 9]].
Explanation 2:
After transposing the matrix, A becomes [[1, 1, 1], [2, 2, 2]]
*/
namespace MatrixTranspose
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<List<int>> A = new List<List<int>>
      {
          new List<int> { 1,2,3,4 },
          new List<int> { 5,6,7,8 },
          new List<int> { 9,2,3,4 },
      };

      A = solve(A);
      for (int i = 0; i < A.Count(); i++)
      {
        for (int j = 0; j < A[0].Count(); j++)
        {
          Console.Write($"{A[i][j]}  ");
        }
        Console.WriteLine("");
      }
    }

    public static List<List<int>> solve(List<List<int>> A)
    {
      List<List<int>> ans = new List<List<int>>();
      for (int i = 0; i < A[0].Count(); i++)
      {
        List<int> row = new List<int>();
        for (int j = 0; j < A.Count(); j++)
        {
          row.Add(A[j][i]);
        }
        ans.Add(row);
      }
      return ans;
    }
  }
}