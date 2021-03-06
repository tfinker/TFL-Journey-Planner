using System;
using System.Collections;

namespace LondonTube{
  public class ListEnumerator<T> : IEnumerator
  {
      public T[] array;

      // Enumerators are positioned before the first element
      // until the first MoveNext() call.
      int position = -1;

      public ListEnumerator(T[] list)
      {
          array = list;
      }

      public bool MoveNext()
      {
          position++;
          return (position < array.Length);
      }

      public void Reset()
      {
          position = -1;
      }

      object IEnumerator.Current
      {
          get
          {
              return Current;
          }
      }

      public T Current
      {
          get
          {
              try
              {
                  return array[position];
              }
              catch (IndexOutOfRangeException)
              {
                  throw new InvalidOperationException();
              }
          }
      }
  }
}