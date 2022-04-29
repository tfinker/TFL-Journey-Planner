using System;


namespace LondonTube
{

    abstract class Heap<T> : IHeap<T> 
    {

      protected T[] heap;
      public int Length {get;set;}

      public Heap(){
        heap = new T[1];
        Length=0;
      }

      abstract public void InsertItem(T item);
      abstract public T RemoveHead();

      public void PrintHeap() {
        if (heap != null) {
          for (int i =0; i< heap.Length; i++){
            Console.WriteLine();
            // need to complete
          }
        }
      }
    }
}