using System;

namespace Tutorial_9 {

  interface IList<T> { //where T : IComparable<T> {

    public void InsertFirst(T item);
    public void InsertLast(T item);
    public void InsertAtIndex(T item, int index);

    public T getFirstItem();
    public T getLastItem();
    public T getItemAtIndex(int index);

    public void RemoveItem(T item);

    // public bool itemExists(T item);
    public int getIndexOfItem(T item);
    public int getLength();

   // public void Sort();
  }
}