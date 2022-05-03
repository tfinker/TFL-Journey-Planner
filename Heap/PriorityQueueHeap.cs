using System;


namespace LondonTube
{

    interface IPriorityQueue<T> where T : IComparable<T> {
      public void Enqueue(T item);
      public T Dequeue();
    }
    
    class PriorityQueueHeap<T> : MinHeap<T>, IPriorityQueue<T> where T : IComparable<T>
    {

      public void Enqueue(T item){
        InsertItem(item);
      }

      public T Dequeue() {
        return RemoveHead();
      }
    }
}