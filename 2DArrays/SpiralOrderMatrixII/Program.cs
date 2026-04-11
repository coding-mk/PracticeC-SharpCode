//Spiral Order Matrix II
/*Problem Description
Given an integer A, generate a square matrix filled with elements from 1 to A2 in spiral order and return the generated square matrix.

Problem Constraints:
1 <= A <= 1000

Input Format:
First and only argument is integer A

Output Format:
Return a 2-D matrix which consists of the elements added in spiral order.

Example Input:
Input 1:
1
Input 2:
2
Input 3:
5

Example Output:
Output 1:
[ [1] ]
Output 2:
[ [1, 2],
  [4, 3] ]
Output 3:
[ [1,   2,  3,  4, 5],
  [16, 17, 18, 19, 6],
  [15, 24, 25, 20, 7],
  [14, 23, 22, 21, 8],
  [13, 12, 11, 10, 9] ]
*/
namespace SpiralOrderMatrixII
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var A = GenerateMatrix(5);
      for (int i = 0; i < A.Length; i++)
      {
        for (int j = 0; j < A[0].Length; j++)
        {
          Console.Write($"{A[i][j]}  ");
        }
        Console.WriteLine("");
      }
    }

    public static int[][] GenerateMatrix(int A)
    {
      int[][] arr = new int[A][];

      // Initialize each inner array
      for (int i = 0; i < A; i++)
      {
        arr[i] = new int[A];
      }
      int K = 1, L = 0, T = 0, R = A - 1, B = A - 1;
      while (K <= A * A)
      {
        for (int i = L; i <= R; i++)
        {
          arr[T][i] = K;
          K += 1;
        }
        T += 1;
        for (int i = T; i <= B; i++)
        {
          arr[i][R] = K;
          K += 1;
        }
        R -= 1;
        for (int i = R; i >= L; i--)
        {
          arr[B][i] = K;
          K += 1;
        }
        B -= 1;
        for (int i = B; i >= T; i--)
        {
          arr[i][L] = K;
          K += 1;
        }
        L += 1;
      }
      return (arr);
    }
  }
}