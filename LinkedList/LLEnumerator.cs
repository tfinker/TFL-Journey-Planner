using System;
using System.Collections;

namespace LondonTube{
  class LinkedListEnumerator<T> : IEnumerator
  {
      //public T[] array;
      public LinkedListObject<T> Node;

      // Enumerators are positioned before the first element
      // until the first MoveNext() call.
      int position = -1;
      private LinkedList<T> linkedList;
      public LinkedListEnumerator(LinkedList<T> obj)
      {
        linkedList = obj;
        Node = linkedList.Head;
      }

      public bool MoveNext()
      {
          position++;
          if (position > 0)
            Node = Node.Next;
          return (position < linkedList.Length);
      }

      public void Reset()
      {
          position = -1;
          Node = linkedList.Head;
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
                  return Node.Data;
              }
              catch (IndexOutOfRangeException)
              {
                  throw new InvalidOperationException();
              }
          }
      }
  }
}