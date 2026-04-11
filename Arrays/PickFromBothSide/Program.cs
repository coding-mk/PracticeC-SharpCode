//Pick from both side
/*Problem Description
You are given an integer array A of size N.
You have to perform B operations. In one operation, you can remove either the leftmost or the rightmost element of the array A.
Find and return the maximum possible sum of the B elements that were removed after the B operations.

NOTE: Suppose B = 3, and array A contains 10 elements, then you can:
Remove 3 elements from front and 0 elements from the back, OR
Remove 2 elements from front and 1 element from the back, OR
Remove 1 element from front and 2 elements from the back, OR
Remove 0 elements from front and 3 elements from the back.

Problem Constraints:
1 <= N <= 105
1 <= B <= N
-103 <= A[i] <= 103

Input Format:
First argument is an integer array A.
Second argument is an integer B.

Output Format:
Return an integer denoting the maximum possible sum of elements you removed.

Example Input:
Input 1:
 A = [5, -2, 3 , 1, 2]
 B = 3
Input 2:
 A = [ 2, 3, -1, 4, 2, 1 ]
 B = 4

Example Output:
Output 1:
 8
Output 2:
 9

Example Explanation:
Explanation 1:
 Remove element 5 from front and element (1, 2) from back so we get 5 + 1 + 2 = 8
Explanation 2:
 Remove the first element and the last 3 elements. So we get 2 + 4 + 2 + 1 = 9
*/
namespace PickFromBothSide
{
  class Program
  {
    public static void Main(string[] args)
    {
      // List<int> list = new List<int>() { 5, -2, 3, 1, 2 };
      // int B = 3;
      List<int> list = new List<int>() { 2, 3, -1, 4, 2, 1 };
      int B = 4;
      Console.WriteLine(solve(list, B));
    }

    public static int solve(List<int> A, int B)
    {
      int N = A.Count();
      List<int> forwordPreFix = new List<int>(new int[N]);
      List<int> reversePreFix = new List<int>(new int[N]);
      forwordPreFix[0] = A[0];
      reversePreFix[0] = A[N - 1];
      for (int i = 1; i < N; i++)
      {
        forwordPreFix[i] = forwordPreFix[i - 1] + A[i];
      }
      int k = 0;
      for (int i = N - 2; i >= 0; i--)
      {
        reversePreFix[k] = reversePreFix[k] + A[i];
        k += 1;
      }
      int max = int.MinValue, sum = 0, n = B - 1, a = B, j = 0;
      for (int i = -1; i < B; i++)
      {
        if (i == -1)
        {
          sum = reversePreFix[B - 1];
        }
        else if (j == -1)
        {
          sum = forwordPreFix[i];
        }
        else
        {
          sum = forwordPreFix[i] + reversePreFix[j];
        }
        if (max < sum)
        {
          max = sum;
        }
        a -= 1;
        j = n - (B - a);
      }
      return (max);
    }
  }
}
