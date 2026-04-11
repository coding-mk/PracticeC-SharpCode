//Rotation Game
/*Problem Description
Given an integer array A of size N and an integer B, you have to print the same array after rotating it B times towards the right.

Problem Constraints
1 <= N <= 106
1 <= A[i] <=108
1 <= B <= 109

Input Format:
There are 2 lines in the input
Line 1: The first number is the size N of the array A. Then N numbers follow which indicate the elements in the array A.
Line 2: A single integer B.

Output Format:
Print array A after rotating it B times towards the right.

Example Input:
Input 1 :
4 1 2 3 4
2

Example Output:
Output 1 :
3 4 1 2

Example Explanation:
Example 1 :
N = 4, A = [1, 2, 3, 4] and B = 2.
Rotate towards the right 2 times - [1, 2, 3, 4] => [4, 1, 2, 3] => [3, 4, 1, 2]
Final array = [3, 4, 1, 2]
*/
namespace RotationGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the array with space separated");
      var arr = Console.ReadLine().Split(' ');
      var rotate = int.Parse(Console.ReadLine());
      int len = int.Parse(arr[0]);
      rotate = rotate % len;
      int i = 1, j = len - rotate;
      while (i < j)
      {
        var c = arr[i];
        arr[i] = arr[j];
        arr[j] = c;
        i++;
        j--;
      }
      j = len;
      i = len - rotate + 1;
      while (i < j)
      {
        var c = arr[i];
        arr[i] = arr[j];
        arr[j] = c;
        i++;
        j--;
      }
      for (int e = len; e > 0; e--)
      {
        Console.Write($"{arr[e]} ");
      }
    }
  }
}
