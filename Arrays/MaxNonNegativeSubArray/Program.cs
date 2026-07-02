namespace MaxNonNegativeSubArray
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //List<int> A = new List<int> { 10, -1, 2, 3, -4, 100 };
      List<int> A = new List<int> { 1, 2, 5, -7, 2, 3 };
      var ans = Solve(A);
      foreach (var i in ans)
      {
        Console.Write($"{i} ");
      }
    }

    public static List<int> Solve(List<int> A)
    {
      int maxSum = 0, newSum = 0;
      List<int> maxArray = new List<int>();
      List<int> newArray = new List<int>();
      foreach (int i in A)
      {
        if (i >= 0)
        {
          newSum += i;
          newArray.Add(i);
        }
        else
        {
          newSum = 0;
          newArray = new List<int>();
        }
        if ((newSum > maxSum) || (newSum == maxSum) && (newArray.Count() > maxArray.Count()))
        {
          maxSum = newSum;
          maxArray = newArray;
        }
      }
      return maxArray;
    }
  }
}