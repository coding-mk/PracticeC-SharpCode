namespace Flip
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string str = "010";
      var ans = Solve(str);
      foreach (var i in ans)
      {
        Console.Write($"{i} ");
      }
    }

    public static List<int> Solve(string str)
    {
      List<int> ans = new List<int>();
      List<int> B = new List<int>();
      int num = 0;
      for (int i = 0; i < str.Count(); i++)
      {
        num = (int)char.GetNumericValue(str[i]);
        if (num == 1)
        {
          B.Add(-1);
        }
        else
        {
          B.Add(1);
        }
      }
      int cur = 0, best = 0, l = 0, r = -1, idx = 0;
      for (int i = 0; i < B.Count(); i++)
      {
        cur += B[i];
        if (cur < 0)
        {
          cur = 0;
          idx = i + 1;
        }
        else if (cur > best)
        {
          l = idx;
          r = i;
          best = cur;
        }
      }
      if (r != -1)
      {
        ans.Add(l + 1);
        ans.Add(r + 1);
        return (ans);
      }
      else
      {
        return (ans);
      }
    }
  }
}