using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortPractice
{
  public class TestHarness
  {
    public void Test<T>(ISorter<T> sorter, List<Test<T>> tests) where T : IComparable
    {
      foreach (var test in tests)
      {
        var output = sorter.Sort(test.Input);
        var expOutput = test.ExpectedOutput;
        var correct = true;

        if (output.Length != expOutput.Length)
        {
          correct = false;
        }
        else
        {
          for (int i = 0; i < output.Length; i++)
          {
            if (output[i].CompareTo(expOutput[i]) != 0)
            {
              correct = false;
              break;
            }
          }
        }
        Console.WriteLine("{0}", correct ? "Correct" : "Incorrect");
      }
    }
  }
}
