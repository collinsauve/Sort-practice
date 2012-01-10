using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortPractice
{
  public class SelectionSort<T> : ISorter<T> where T: IComparable
  {
    public T[] Sort(T[] data)
    {
      var ret = new T[data.Length];
      data.CopyTo(ret, 0);

      for (int i = 0; i < ret.Length - 1; i++)
      {
        var smallestIndex = i;
        for (int j = i + 1; j < ret.Length; j++)
        {
          if (ret[j].CompareTo(ret[smallestIndex]) < 0) smallestIndex = j;
        }

        if (smallestIndex != i)
        {
          var temp = ret[i];
          ret[i] = ret[smallestIndex];
          ret[smallestIndex] = temp;
        }
      }
      return ret;
    }
  }
}
