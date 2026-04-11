//Star Pattern I
/*Problem Description
Write a program to input an integer N from user and print hollow diamond star pattern series of N lines.
See example for clarifications over the pattern.

Problem Constraints:
1 <= N <= 1000

Input Format:
First line is an integer N

Output Format:
N lines conatining only char '*' as per the question.

Example Input:
Input 1:
4
Input 2:
6

Example Output:
Output 1:
********
***  ***
**    **
*      *
*      *
**    **
***  ***
********
Output 2:
************
*****  *****
****    ****
***      ***
**        **
*          *
*          *
**        **
***      ***
****    ****
*****  *****
************
*/
namespace StarPatternI
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter length of an array");
      int A = int.Parse(Console.ReadLine());
      Solve(A);
    }

    public static void Solve(int A)
    {
      for (int i = A; i > 0; i--)
      {
        for (int j = 0; j < A; j++)
        {
          if (j < i)
          {
            Console.Write("*");
          }
          else
          {
            Console.Write(" ");
          }
        }

        for (int j = A; j >= 1; j--)
        {
          if (j <= i)
          {
            Console.Write("*");
          }
          else
          {
            Console.Write(" ");
          }
        }
        Console.WriteLine("");
      }

      for (int i = A; i > 0; i--)
      {
        for (int j = A; j >= 1; j--)
        {
          if (j >= i)
          {
            Console.Write("*");
          }
          else
          {
            Console.Write(" ");
          }
        }

        for (int j = 1; j <= A; j++)
        {
          if (j < i)
          {
            Console.Write(" ");
          }
          else
          {
            Console.Write("*");
          }
        }
        Console.WriteLine("");
      }
    }
  }
}
