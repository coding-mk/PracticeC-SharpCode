//Minor Diagonal Sum
/*Problem Description
You are given a N X N integer matrix. You have to find the sum of all the minor diagonal elements of A.
Minor diagonal of a M X M matrix A is a collection of elements A[i, j] such that i + j = M + 1 (where i, j are 1-based).

Problem Constraints:
1 <= N <= 103
-1000 <= A[i][j] <= 1000

Input Format:
First and only argument is a 2D integer matrix A.

Output Format:
Return an integer denoting the sum of minor diagonal elements.

Example Input:
Input 1:
 A = [[1, -2, -3],
      [-4, 5, -6],
      [-7, -8, 9]]
Input 2:
 A = [[3, 2],
      [2, 3]]

Example Output:
Output 1:
 -5 
Output 2:
 4 

Example Explanation:
Explanation 1:
 A[1][3] + A[2][2] + A[3][1] = (-3) + 5 + (-7) = -5
Explanation 2:
 A[1][2] + A[2][1] = 2 + 2 = 4
*/
namespace MinorDiagonalSum
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<List<int>> A = new List<List<int>>
      {
          new List<int> { 1,2,3 },
          new List<int> { 5,6,7 },
          new List<int> { 9,2,3 },
      };

      Console.WriteLine(solve(A));
    }

    public static int solve(List<List<int>> A)
    {
      int i = 0, j = A[0].Count() - 1, sum = 0;
      while (i < A.Count())
      {
        sum += A[i][j];
        i++;
        j--;
      }
      return sum;
    }
  }
}