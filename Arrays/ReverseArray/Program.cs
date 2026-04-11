// Reverse the Array
/*Problem Description
You are given a constant array A.
You are required to return another array which is the reversed form of the input array.

Problem Constraints
1 <= A.size() <= 10000
1 <= A[i] <= 10000

Input Format
First argument is a constant array A.

Output Format
Return an integer array.

Example Input
Input 1:
A = [1,2,3,2,1]
Input 2:
A = [1,1,10]

Example Output
Output 1:
 [1,2,3,2,1] 
Output 2:
 [10,1,1] 

Example Explanation
Explanation 1:
Reversed form of input array is same as original array

Explanation 2:
Clearly, Reverse of [1,1,10] is [10,1,1]*/
namespace ReverseArray
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter length of an array");
      int len = int.Parse(Console.ReadLine());
      int[] A = new int[len];
      Console.WriteLine("Enter array elements");
      for (int j = 0; j < len; j++)
      {
        A[j] = int.Parse(Console.ReadLine());
      }
      var arr = reverseArray(A);

      foreach (int i in arr)
      {
        Console.WriteLine(i);
      }
    }

    public static int[] reverseArray(int[] A)
    {
      int i = 0, j = A.Length - 1, c = 0;
      while (i <= j)
      {
        c = A[i];
        A[i] = A[j];
        A[j] = c;
        i++;
        j--;
      }
      return A;
    }
  }
}
