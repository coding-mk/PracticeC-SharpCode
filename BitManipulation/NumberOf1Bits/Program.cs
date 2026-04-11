//Number of 1 Bits
/*Problem Description
Write a function that takes an integer and returns the number of 1 bits present in its binary representation.

Problem Constraints:
1 <= A <= 109

Input Format:
First and only argument contains integer A

Output Format:
Return an integer

Example Input:
Input 1:
11
Input 2:
6

Example Output:
Output 1:
3
Output 2:
2

Example Explanation:
Explaination 1:
11 is represented as 1011 in binary.
Explaination 2:
6 is represented as 110 in binary.
 */
namespace NumberOf1Bits
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(NumSetBits(3));
      Console.WriteLine(NumSetBits(11));
    }

    public static int NumSetBits(int A)
    {
      int rem = 0, count = 0;
      while (A > 0)
      {
        rem = A % 2;
        if (rem == 1)
        {
          count += 1;
        }
        A = A / 2;
      }
      return (count);
    }
  }
}