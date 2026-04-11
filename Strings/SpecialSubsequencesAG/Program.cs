//Special Subsequences "AG"
/*Problem Description
You have given a string A having Uppercase English letters.
You have to find how many times subsequence "AG" is there in the given string.
NOTE: Return the answer modulo 109 + 7 as the answer can be very large.

Problem Constraints:
1 <= length(A) <= 105

Input Format:
First and only argument is a string A.

Output Format:
Return an integer denoting the answer.

Example Input:
Input 1:
 A = "ABCGAG"
Input 2:
 A = "GAB"

Example Output:
Output 1:
 3
Output 2:
 0

Example Explanation:
Explanation 1:
 Subsequence "AG" is 3 times in given string 
Explanation 2:
 There is no subsequence "AG" in the given string.
*/
namespace SpecialSubsequencesAG
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(Solve("ABCGAG"));
    }

    public static int Solve(string A)
    {
      long ans = 0;
      int C = 0;
      for (int i = A.Length - 1; i >= 0; i--)
      {
        if (A[i] == 'G')
        {
          C++;
        }
        if (A[i] == 'A')
        {
          ans = ans + ((long)C);
        }
      }
      long t = ans % 1000000007;
      return ((int)t);
    }

  }
}

