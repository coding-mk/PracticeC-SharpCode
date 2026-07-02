//Check Palindrome using Recursion
/*Problem Description

Write a recursive function that checks whether string A is a palindrome or Not.
Return 1 if the string A is a palindrome, else return 0.

Note: A palindrome is a string that's the same when read forward and backward.






Problem Constraints

1 <= |A| <= 50000




String A consists only of lowercase letters.






Input Format

The first and only argument is a string A.



Output Format

Return 1 if the string A is a palindrome, else return 0.



Example Input

Input 1:

 A = "naman"
Input 2:

 A = "strings"


Example Output

Output 1:

 1
Output 2:

 0


Example Explanation

Explanation 1:

 "naman" is a palindomic string, so return 1.
Explanation 2:

 "strings" is not a palindrome, so return 0.
 */
namespace CheckPalindromeUsingRecursion
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //string str = "scaleracademy";
      string str = "naman";
      Console.WriteLine(CheckPalindrome(str, 0, str.Count() - 1));
    }

    public static int CheckPalindrome(string str, int start, int end)
    {
      if (start > end)
      {
        return 1;
      }
      if (str[start] != str[end])
      {
        return 0;
      }
      return CheckPalindrome(str, start + 1, end - 1);
    }



  }
}