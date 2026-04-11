//Matrix Scalar Product
/*Problem Description
You are given a matrix A and and an integer B, you have to perform scalar multiplication of matrix A with an integer B.

Problem Constraints:
1 <= A.size() <= 1000
1 <= A[i].size() <= 1000
1 <= A[i][j] <= 1000
1 <= B <= 1000

Input Format:
First argument is 2D array of integers A representing matrix.
Second argument is an integer B.

Output Format
You have to return a 2D array of integers after doing required operations.

Example Input:
Input 1:
A = [[1, 2, 3],
     [4, 5, 6],
     [7, 8, 9]]
B = 2 
Input 2:
A = [[1]]
B = 5 

Example Output:
Output 1:
[[2, 4, 6], 
[8, 10, 12], 
[14, 16, 18]]
Output 2:
[[5]]

Example Explanation:
Explanation 1:
==> ( [[1, 2, 3],[4, 5, 6],[7, 8, 9]] ) * 2
==> [[2*1, 2*2, 2*3],
     [2*4, 2*5, 2*6],
     [2*7, 2*8, 2*9]]
==> [[2,   4,  6], 
     [8,  10, 12], 
     [14, 16, 18]]
Explanation 2:
==> ( [[1]] ) * 5
==> [[5*1]]
==> [[5]]
*/
namespace MatrixScalarProduct
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
      int B = 2;


      // List<List<int>> A = new List<List<int>>
      // {
      //     new List<int> { 1 }
      // };
      // int B = 5;

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

    public static List<List<int>> solve(List<List<int>> A, int B)
    {
      for (int i = 0; i < A.Count(); i++)
      {
        for (int j = 0; j < A[0].Count(); j++)
        {
          A[i][j] = A[i][j] * B;
        }
      }
      return A;
    }
  }
}
