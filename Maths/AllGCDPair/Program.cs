//All GCD Pair
/*Problem Description

Given an array of integers A of size N containing GCD of every possible pair of elements of another array.





Find and return the original numbers used to calculate the GCD array in any order. For example, if original numbers are {2, 8, 10} then the given array will be {2, 2, 2, 2, 8, 2, 2, 2, 10}.









Problem Constraints

1 <= N <= 10000

1 <= A[i] <= 109



Input Format

The first and only argument given is the integer array A.



Output Format

Find and return the original numbers which are used to calculate the GCD array in any order.



Example Input

Input 1:

 A = [2, 2, 2, 2, 8, 2, 2, 2, 10]
Input 2:

 A = [5, 5, 5, 15]


Example Output

Output 1:

 [2, 8, 10]
Output 2:

 [5, 15]


Example Explanation

Explanation 1:

 Initially, array A = [2, 2, 2, 2, 8, 2, 2, 2, 10].
 2 is the gcd between 2 and 8, 2 and 10.
 8 and 10 are the gcds pair with itself.
 Therefore, [2, 8, 10] is the original array.
Explanation 2:

 Initially, array A = [5, 5, 5, 15].
 5 is the gcd between 5 and 15.
 15 is the gcds pair with itself.
 Therefore, [5, 15] is the original array.
 */
namespace AllGCDPair
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> A = new List<int> { 2, 2, 2, 2, 8, 2, 2, 2, 10 };
            foreach (var item in Solve(A))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**********");
            List<int> B = new List<int> { 5, 5, 5, 15 };
            foreach (var item in Solve(B))
            {
                Console.WriteLine(item);
            }
        }

        public static int Gcd(int A, int B)
        {
            if (A == 0)
                return B;
            return Gcd(B % A, A);
        }
        public static List<int> Solve(List<int> A)
        {
            List<int> ans = new List<int>();
            A.Sort((x, y) => y.CompareTo(x));
            Dictionary<int, int> mp = new Dictionary<int, int>();
            // mp stores the count of A[i]'s that are to be deleted from the array
            for (int i = 0; i < A.Count; i++)
            {
                int x = A[i];
                if (mp.ContainsKey(x) && mp[x] > 0)
                    mp[x] = mp[x] - 1;
                else
                {
                    for (int j = 0; j < ans.Count; j++)
                    {
                        int g = Gcd(ans[j], x);

                        if (mp.ContainsKey(g))
                            mp[g] = mp[g] + 2;
                        else
                            mp[g] = 2;

                        // we are adding 2 to the mp as there will 2 pairs gcd(ans[j],A[i]) and gcd(A[i],ans[j])
                    }
                    ans.Add(x);
                }
            }
            return ans;
        }
    }
}