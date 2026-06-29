//Add One To Number
/*Problem Description
Given a non-negative number represented as an array of digits, add 1 to the number ( increment the number represented by the digits ).

The digits are stored such that the most significant digit is at the head of the list.

NOTE: Certain things are intentionally left unclear in this question which you should practice asking the interviewer. For example: for this problem, the following are some good questions to ask :

Q: Can the input have 0's before the most significant digit. Or, in other words, is 0 1 2 3 a valid input?
A: For the purpose of this question, YES
Q: Can the output have 0's before the most significant digit? Or, in other words, is 0 1 2 4 a valid output?
A: For the purpose of this question, NO. Even if the input has zeroes before the most significant digit.

Problem Constraints
1 <= size of the array <= 1000000

Input Format
First argument is an array of digits.

Output Format
Return the array of digits after adding one.

Example Input
Input 1:
[1, 2, 3]

Example Output
Output 1:
[1, 2, 4]

Example Explanation
Explanation 1:
Given vector is [1, 2, 3].
The returned vector should be [1, 2, 4] as 123 + 1 = 124.
 */
namespace RainWaterTrapped
{
  class Program
  {
    static void Main(string[] args)
    {
      //List<int> A = new List<int> { 0, 1, 0, 0, 2, 9 };
      List<int> A = new List<int> { 9, 9 };
      var ans = PlusOne(A);
      foreach (var i in ans)
      {
        Console.Write($"{i} ");
      }
    }

    public static List<int> PlusOne(List<int> A)
    {
      List<int> ans = new List<int>();
      int sum = 0, C = 0, N = A.Count();
      sum = A[N - 1] + 1;
      if (sum == 10)
      {
        C = 1;
        ans.Add(0);
      }
      else
      {
        ans.Add(sum);
      }
      int end = 0;
      for (int i = 0; i < N; i++)
      {
        if (A[i] != 0)
        {
          end = i;
          break;
        }
      }
      for (int j = N - 2; j >= end; j--)
      {
        sum = A[j] + C;
        if (sum == 10)
        {
          C = 1;
          ans.Add(0);
        }
        else
        {
          C = 0;
          ans.Add(sum);
        }
      }
      if (C == 1)
      {
        ans.Add(1);
      }
      int r = 0, k = ans.Count() - 1, temp = 0;
      while (r < k)
      {
        temp = ans[r];
        ans[r] = ans[k];
        ans[k] = temp;
        r++;
        k--;
      }
      return ans;
    }
  }
}