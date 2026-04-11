//Special Index
/*Problem Description
Given an array, arr[] of size N, the task is to find the count of array indices such that removing an element from these indices makes the sum of even-indexed and odd-indexed array elements equal.

Problem Constraints:
1 <= N <= 105
-105 <= A[i] <= 105
Sum of all elements of A <= 109

Input Format:
First argument contains an array A of integers of size N

Output Format:
Return the count of array indices such that removing an element from these indices makes the sum of even-indexed and odd-indexed array elements equal.

Example Input:
Input 1:
A = [2, 1, 6, 4]
Input 2:
A = [1, 1, 1]

Example Output:
Output 1:
1
Output 2:
3

Example Explanation
Explanation 1:
Removing arr[1] from the array modifies arr[] to { 2, 6, 4 } such that, arr[0] + arr[2] = arr[1]. 
Therefore, the required output is 1. 
Explanation 2:

Removing arr[0] from the given array modifies arr[] to { 1, 1 } such that arr[0] = arr[1] 
Removing arr[1] from the given array modifies arr[] to { 1, 1 } such that arr[0] = arr[1] 
Removing arr[2] from the given array modifies arr[] to { 1, 1 } such that arr[0] = arr[1] 
Therefore, the required output is 3.
*/
namespace SpecialIndex
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>() { 2, 1, 6, 4 };
      //List<int> list = new List<int>() { 1, 1, 1 };
      Console.WriteLine(solve(list));
    }

    public static int solve(List<int> A)
    {
      int N = A.Count;
      if (N == 0) return 0;

      // initialize prefix arrays with size N
      List<int> pfEven = new List<int>(new int[N]);
      List<int> pfOdd = new List<int>(new int[N]);

      // base case
      pfEven[0] = A[0];
      pfOdd[0] = 0;

      // build prefix sums
      for (int i = 1; i < N; i++)
      {
        if (i % 2 == 1)
        {
          pfEven[i] = pfEven[i - 1];
          pfOdd[i] = pfOdd[i - 1] + A[i];
        }
        else
        {
          pfEven[i] = pfEven[i - 1] + A[i];
          pfOdd[i] = pfOdd[i - 1];
        }
      }

      int ans = 0;
      for (int i = 0; i < N; i++)
      {
        int Todd, Teven;

        if (i == 0)
        {
          Todd = pfEven[N - 1] - pfEven[i];
          Teven = pfOdd[N - 1] - pfOdd[i];
        }
        else
        {
          Todd = pfOdd[i - 1] + (pfEven[N - 1] - pfEven[i]);
          Teven = pfEven[i - 1] + (pfOdd[N - 1] - pfOdd[i]);
        }

        if (Todd == Teven)
        {
          ans++;
        }
      }

      return ans;
    }
  }
}
