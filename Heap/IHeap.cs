using System;


namespace Tutorial_9
{

    interface IHeap<T>
    {
    
      // add to heap
      // remove from heap

      public void InsertItem(T item);

      public T RemoveHead();

      public void PrintHeap();
    }
}