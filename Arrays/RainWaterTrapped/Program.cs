//Rain Water Trapped
/*Problem Description

Imagine a histogram where the bars' heights are given by the array A. Each bar is of uniform width, which is 1 unit. When it rains, water will accumulate in the valleys between the bars.

Your task is to calculate the total amount of water that can be trapped in these valleys.

Example:

The Array A = [5, 4, 1, 4, 3, 2, 7] is visualized as below. The total amount of rain water trapped in A is 11.


Rain Water Trapped




Problem Constraints

1 <= |A| <= 105
0 <= A[i] <= 105



Input Format

First and only argument is the Integer Array, A.



Output Format

Return an Integer, denoting the total amount of water that can be trapped in these valleys



Example Input

Input 1:

 A = [0, 1, 0, 2]
Input 2:

A = [1, 2]


Example Output

Output 1:

1
Output 2:

0

*/
namespace RainWaterTrapped
{
  class Program
  {
    static void Main(string[] args)
    {
      //List<int> A = new List<int> { 0, 1, 0, 2 };
      List<int> A = new List<int> { 1, 2 };
      Console.WriteLine(Trap(A));
    }

    public static int Trap(List<int> A)
    {
      List<int> leftMax = new List<int>();
      List<int> rightMax = new List<int>();
      int left = int.MinValue, right = int.MinValue, min = 0, sum = 0, diff = 0;
      foreach (int i in A)
      {
        if (i > left)
        {
          left = i;
        }
        leftMax.Add(left);
      }
      for (int i = A.Count() - 1; i >= 0; i--)
      {
        if (A[i] > right)
        {
          right = A[i];
        }
        rightMax.Add(right);
      }
      int r = 0, k = rightMax.Count() - 1, temp = 0;
      while (r < k)
      {
        temp = rightMax[r];
        rightMax[r] = rightMax[k];
        rightMax[k] = temp;
        r++;
        k--;
      }
      for (int i = 0; i < A.Count(); i++)
      {
        min = Math.Min(leftMax[i], rightMax[i]);
        diff = min - A[i];
        if (diff > 0)
        {
          sum = sum + diff;
        }
      }
      return sum;
    }
  }
}
