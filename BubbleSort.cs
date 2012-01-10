using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortPractice
{
  public class BubbleSort<T> : ISorter<T> where T : IComparable
  {
    public T[] Sort(T[] data)
    {
      var ret = new T[data.Length];
      data.CopyTo(ret, 0);

      for (int i = data.Length - 1; i >= 1; i--)
      {
        for (int j = 0; j < data.Length - 1; j++)
        {
          if (ret[j].CompareTo(ret[j + 1]) > 0)
          {
            var temp = ret[j];
            ret[j] = ret[j + 1];
            ret[j + 1] = temp;
          }
        }
      }
      return ret;
    }
  }
}
