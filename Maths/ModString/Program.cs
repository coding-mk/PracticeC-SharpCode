//Mod String
/*Problem Description

You are given a large number in the form of a string A where each character denotes a digit of the number.
You are also given a number B. You have to find out the value of A % B and return it.



Problem Constraints

1 <= A.length() <= 105
0 <= Ai <= 9
1 <= B <= 109


Input Format

The first argument is a string A.
The second argument is an integer B.


Output Format

Return a single integer denoting the value of A % B.


Example Input

Input 1:
A = "143"
B = 2
Input 2:

A = "43535321"
B = 47


Example Output

Output 1:
1
Output 2:

20


Example Explanation

Explanation 1:
143 is an odd number so 143 % 2 = 1.
Explanation 2:

43535321 % 47 = 20
 */
namespace ModString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(FindMod("143", 2));
            Console.WriteLine(FindMod("43535321", 47));
        }

        public static int FindMod(string A, int B)
        {
            int ans = 0, c = 0, mul = 0, pow = 0, N = A.Count();
            for (int i = 0; i < N; i++)
            {
                c = int.Parse(A[i].ToString());
                pow = Power(10, N - i - 1, B);
                mul = (int)(((long)(c % B) * pow) % B);
                ans = (ans + mul) % B;
            }
            return (ans % B);
        }

        public static int Power(int A, int B, int C)
        {
            if (A == 0)
            {// only for 0^0 
                return (0);
            }
            if (B == 0)
            {
                return (1);
            }
            A = (A % C + C) % C;
            long halfpow = Power(A, B / 2, C);
            halfpow = (halfpow * halfpow) % C;
            if (B % 2 == 0)
            {
                return ((int)halfpow);
            }
            else
            {
                return ((int)((halfpow * A) % C));
            }
        }
    }
}