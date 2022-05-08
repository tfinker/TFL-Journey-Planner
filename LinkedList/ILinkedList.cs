using System;

namespace LondonTube {

  interface ILinkedList<T> {

    public void InsertFirst(T item);
    public void InsertLast(T item);
    public void InsertAtIndex(T item, int index);

    public void InsertAfterNode(LinkedListObject<T> node, T data);
    
    public LinkedListObject<T> findNode(T data);
    
    public LinkedListObject<T> getItemAtIndex(int index);

    public void RemoveItem(T item);

    

   
  }
}