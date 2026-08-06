//Sorted Permutation Rank with Repeats
/*Problem Description

Given a string A, find the rank of the string amongst its permutations sorted lexicographically.

Note that the characters might be repeated. If the characters are repeated, we need to look at the rank in unique permutations.

Look at the example for more details.

NOTE:

The answer might not fit in an integer, so return your answer % 1000003 where 1000003 is a prime number.
String A can consist of both lowercase and uppercase letters. Characters with lesser ASCII values are considered smaller, i.e., 'a' > 'Z'.



Problem Constraints

1 <= len(A) <= 1000000



Input Format

First argument is a string A.



Output Format

Return an integer denoting the rank.



Example Input

Input 1:

 A = "aba"
Input 2:

 A = "bca"






Example Output

Output 1:

 2
Output 2:

 4






Example Explanation

Explanation 1:


 The order permutations with letters 'a', 'a', and 'b' :
    aab
    aba 
    baa
 So, the rank is 2.
Explanation 2:

 The order permutations with letters 'a', 'b', and 'c' :
    abc
    acb 
    bac
    bca
    cab
    cba
 So, the rank is 4.
 */
namespace SortedPermutationRankRepeats
{
    public class Program
    {
        private static int MOD = 1000003;

        public static void Main(string[] args)
        {
            Console.WriteLine(FindRank("aba"));
            Console.WriteLine(FindRank("bca"));
        }

        public static int FindRank(string A)
        {

            // Initializations
            List<int> charCount = new List<int>(256);

            for (int i = 0; i < 256; i++)
                charCount.Add(0);
            for (int i = 0; i < A.Length; i++)
            {
                int ch = (int)A[i];
                charCount[ch] = charCount[ch] + 1;
            }

            List<int> fact = new List<int>(); // fact[i] will contain i! % MOD
            InitializeFactorials(A.Length + 1, fact);

            long rank = 1;

            for (int i = 0; i < A.Length; i++)
            {
                // find number of permutations placing character smaller than A[i] at ith position 
                // among characters from i to A.Length 
                long less = 0;
                int remaining = A.Length - i - 1;
                for (int ch = 0; ch < A[i]; ch++)
                {
                    if (charCount[ch] == 0) continue;
                    // Lets try placing ch as the first character in remaining characters
                    // and check the number of permutation possible.
                    charCount[ch] = charCount[ch] - 1;
                    long numPermutation = fact[remaining];

                    for (int c = 0; c < 128; c++)
                    {
                        if (charCount[c] <= 1) continue;
                        numPermutation = (numPermutation * InverseNumber(fact[charCount[c]])) % MOD;
                    }

                    charCount[ch] = charCount[ch] + 1;
                    less = (less + numPermutation) % MOD;
                }

                rank = (rank + less) % MOD;
                // remove the current character from the set. 
                charCount[(int)A[i]] = charCount[(int)A[i]] - 1;
            }
            return (int)rank;

        }

        public static void InitializeFactorials(int totalLen, List<int> fact)
        {
            // calculates factorial
            long factorial = 1;
            fact.Add(1); // 0!= 1
            for (int curIndex = 1; curIndex < totalLen; curIndex++)
            {
                factorial = (factorial * curIndex) % MOD;
                fact.Add((int)factorial);
            }
            return;
        }

        public static long Pow(long x, int y, int k)
        {
            long result = 1;
            while (y > 0)
            {
                if (y % 2 == 1)
                {
                    result = (result * x) % k;
                    y--;
                }
                y >>= 1;
                x = (x * x) % k;
            }
            return result;
        }
        public static long InverseNumber(int num)
        {
            // Find the modular multiplicative inverse
            // Calculates (num ^ (MOD - 2)) % MOD
            return Pow(num, MOD - 2, MOD);
        }
    }
}