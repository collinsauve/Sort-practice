using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortPractice
{
  public static class Program
  {
    public static void Main(string[] args)
    {
      var harness = new TestHarness();

      harness.Test(new BubbleSort<int>(), GetIntTests());

      harness.Test(new BubbleSort<string>(), GetStringTests());

      Console.ReadKey();
    }

    public static List<Test<int>> GetIntTests()
    {
      return new List<Test<int>>
      {
        new Test<int>(new int[] { 5, 3, 6, 7}, new int[] { 3, 5, 6, 7}),
        new Test<int>(new int[] { 5, 4, 6, 8, 1}, new int[] { 1, 4, 5, 6, 8})
      };
    }

    public static List<Test<string>> GetStringTests()
    {
      return new List<Test<string>>
      {
        new Test<string>(new string[] { "5", "3", "6", "7"}, new string[] { "3", "5", "6", "7"}),
        new Test<string>(new string[] { "5", "4", "6", "8", "1"}, new string[] { "1", "4", "5", "6", "8"})
      };
    }
  }
}
