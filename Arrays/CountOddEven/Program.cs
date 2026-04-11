// See https://aka.ms/new-console-template for more information
namespace CountOddEven
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] a = [1, 2, 3, 4, 5, 6, 7, 8, 9];
      CountOddEven(a);
    }

    public static void CountOddEven(int[] a)
    {
      int even = 0, odd = 0;
      foreach (int i in a)
      {
        if (i % 2 == 0)
        {
          even++;
        }
        else
        {
          odd++;
        }
      }
      Console.WriteLine($"Odd : {odd}  Even : {even}");
    }
  }
}
