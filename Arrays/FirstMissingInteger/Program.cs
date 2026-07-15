//First Missing Integer
/*Problem Description

Given an unsorted integer array, A of size N. Find the first missing positive integer.





Note: Your algorithm should run in O(n) time and use constant space.







Problem Constraints

1 <= N <= 1000000

-109 <= A[i] <= 109



Input Format

First argument is an integer array A.



Output Format

Return an integer denoting the first missing positive integer.



Example Input

Input 1:

[1, 2, 0]
Input 2:

[3, 4, -1, 1]
Input 3:

[-8, -7, -6]






Example Output

Output 1:

3
Output 2:

2
Output 3:

1






Example Explanation

Explanation 1:

A = [1, 2, 0]
First positive integer missing from the array is 3.
Explanation 2:

A = [3, 4, -1, 1]
First positive integer missing from the array is 2.
Explanation 3:

A = [-8, -7, -6]
First positive integer missing from the array is 1.
 */
namespace FirstMissingInteger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> A = new List<int> { 3, 4, -1, 1 };
            int result = FirstMissingPositive(A);
            Console.WriteLine(result);
        }

        public static int FirstMissingPositive(List<int> A)
        {
            int N = A.Count, currentIdx = 0, i = 0, temp = 0;
            while (i < N)
            {
                if (A[i] >= 1 && A[i] <= N)
                {
                    currentIdx = A[i] - 1;
                    if (A[i] != A[currentIdx])
                    {
                        temp = A[i];
                        A[i] = A[currentIdx];
                        A[currentIdx] = temp;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    i++;
                }
            }
            for (int j = 0; j < N; j++)
            {
                if (A[j] != j + 1)
                {
                    return j + 1;
                }
            }
            return N + 1;
        }
    }
}