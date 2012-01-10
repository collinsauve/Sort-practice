using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortPractice
{
  public interface ISorter<T> where T : IComparable
  {
    T[] Sort(T[] data);
  }
}
