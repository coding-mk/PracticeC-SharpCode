//Row Sum
/*Problem Description
You are given a 2D matrix A of integers.
Your task is to compute the sum of elements in each row and return a 1D array where each element represents the sum of a corresponding row in the matrix.

Problem Constraints:
1 <= A.size() <= 103
1 <= A[i].size() <= 103
1 <= A[i][j] <= 103

Input Format:
First argument A is a 2D array of integers.(2D matrix).

Output Format:
Return an array containing row-wise sums of original matrix.

Example Input:
Input 1:
[1,2,3,4]
[5,6,7,8]
[9,2,3,4]

Example Output:
Output 1:
[10,26,18]

Example Explanation:
Explanation 1
Row 1 = 1+2+3+4 = 10
Row 2 = 5+6+7+8 = 26
Row 3 = 9+2+3+4 = 18
*/
namespace RowSum
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

      var ans = solve(A);
      for (int i = 0; i < ans.Count(); i++)
      {
        Console.Write($"{ans[i]} ");
      }
    }

    public static List<int> solve(List<List<int>> A)
    {
      List<int> ans = new List<int>();
      int sum = 0;
      for (int i = 0; i < A.Count(); i++)
      {
        sum = 0;
        for (int j = 0; j < A[0].Count(); j++)
        {
          sum += A[i][j];
        }
        ans.Add(sum);
      }
      return ans;
    }
  }
}
