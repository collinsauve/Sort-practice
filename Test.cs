using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortPractice
{
  public class Test<T>
  {
    public T[] Input { get; set; }
    public T[] ExpectedOutput { get; set; }

    public Test(T[] input, T[] expectedOutput)
    {
      this.Input = input;
      this.ExpectedOutput = expectedOutput;
    }
  }
}
