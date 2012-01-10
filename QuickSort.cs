using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortPractice
{
  public class QuickSort<T> : ISorter<T> where T : IComparable
  {
    private Random rnd = new Random();


    private void Sort(T[] data, int left, int right)
    {
      if (right - left <= 0) return;

      var i = left;
      var j = right;
      var pivotIndex = Convert.ToInt32((left + right) / 2);
      T pivot = data[pivotIndex];

      while (i < j)
      {
        while (data[i].CompareTo(pivot) < 0) i++;
        while (data[j].CompareTo(pivot) > 0) j--;

        if (i <= j)
        {
          T temp = data[i];
          data[i++] = data[j];
          data[j--] = temp;
        }
      }

      if (left < j) Sort(data, left, j);

      if (i < right) Sort(data, i, right);

    }


    public T[] Sort(T[] data)
    {
      var ret = new T[data.Length];
      data.CopyTo(ret, 0);
      Sort(ret, 0, ret.Length - 1);
      return ret;
    }

  }
}
