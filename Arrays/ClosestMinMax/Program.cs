//Closest MinMax
/*Problem Description
Given an array A, find the size of the smallest subarray such that it contains at least one occurrence of the maximum value of the array
and at least one occurrence of the minimum value of the array.

Problem Constraints:
1 <= |A| <= 2000

Input Format:
First and only argument is vector A

Output Format:
Return the length of the smallest subarray which has at least one occurrence of minimum and maximum element of the array

Example Input:
Input 1:
A = [1, 3, 2]
Input 2:
A = [2, 6, 1, 6, 9]

Example Output:
Output 1:
 2
Output 2:
 3

Example Explanation:
Explanation 1:
 Take the 1st and 2nd elements as they are the minimum and maximum elements respectievly.
Explanation 2:
 Take the last 3 elements of the array.
*/
namespace ClosestMinMax
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> list = new List<int>() { 2, 6, 1, 6, 9 };
      Console.WriteLine(Solve(list));
    }

    public static int Solve(List<int> A)
    {
      int max = int.MinValue, min = int.MaxValue;
      foreach (int i in A)
      {
        if (max < i)
        {
          max = i;
        }
        if (min > i)
        {
          min = i;
        }
      }
      int N = A.Count(), ans = A.Count(), maxI = -1, minI = -1, l;
      for (int i = N - 1; i >= 0; i--)
      {
        if (A[i] == min)
        {
          minI = i;
          if (maxI != -1)
          {
            l = Math.Abs(minI - maxI) + 1;
            ans = Math.Min(ans, l);
          }
        }
        if (A[i] == max)
        {
          maxI = i;
          if (minI != -1)
          {
            l = Math.Abs(minI - maxI) + 1;
            ans = Math.Min(ans, l);
          }
        }
      }
      return (ans);
    }
  }
}
