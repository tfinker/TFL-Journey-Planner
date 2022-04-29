using System;


namespace LondonTube
{

    interface IHeap<T>
    {
      public void InsertItem(T item);

      public T RemoveHead();

      public void PrintHeap();
    }
}