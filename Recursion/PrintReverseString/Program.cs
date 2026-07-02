//Print reverse string
/*Problem Description

Write a recursive function that takes a string, S, as input and prints the characters of S in reverse order.



Problem Constraints

1 <= |s| <= 1000



Input Format

First line of input contains a string S.



Output Format

Print the character of the string S in reverse order.



Example Input

Input 1:

 scaleracademy
Input 2:

 cool


Example Output

Output 1:

 ymedacarelacs
Output 2:

 looc
*/
namespace PrintReverseString
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //string str = "scaleracademy";
      string str = "cool";
      solve(str, str.Count() - 1);
    }

    public static void solve(string str, int index)
    {
      if (index < 0)
      {
        return;
      }

      Console.Write(str[index]);
      solve(str, index - 1);
    }



  }
}
