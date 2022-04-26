using System;
using System.Collections;

namespace Tutorial_9 {

  public class ItemNotFoundException : Exception {
    public ItemNotFoundException() : base() {}
    public ItemNotFoundException(string message) : base(message) {}
    
  }
  
  class List<T> : IList<T>, IEnumerable where T : IComparable<T> {

    T[] array;

    public List() {
      array = new T[0];
    }

    private void InsertIntoArray(T item, int index){
           
      T[] newArray = new T[array.Length+1];

      if (index == 0){
        newArray[index] = item;
        Array.Copy(array, 0, newArray, index+1, array.Length );
      }
      else if ( index == array.Length ){
        Array.Copy(array, 0, newArray, 0, index );
        newArray[index] = item;
      }
      else if (index > 0 && index < array.Length) {
        Array.Copy(array, 0, newArray, 0, index );
        newArray[index] = item;
        Array.Copy(array, index, newArray, index+1, array.Length - index );
      }

      array = newArray;
    }

    // private void RemoveFromArray(ref T[] array, T item){
    //   Array.Resize(ref array, array.Length+1);
    //   array[array.Length-1] = item;
    // }

    public void InsertFirst(T item) {
      InsertAtIndex(item, 0);
    }
    public void InsertLast(T item) {
      InsertAtIndex(item, array.Length);
    }
    public void InsertAtIndex(T item, int index) {
      if (index > (array.Length)){
        throw new IndexOutOfRangeException();
      }
      InsertIntoArray(item, index);
    }


    public T getFirstItem() {
      if (array.Length == 0){
        return default(T);
      }
      return array[0];
    }
    public T getLastItem() {
      if (array.Length == 0){
        throw new IndexOutOfRangeException();
      }
      return array[array.Length];
    }
    public T getItemAtIndex(int index) {
      if (array.Length == 0){
        throw new IndexOutOfRangeException();
      }
      return array[index];
    }

    // public bool itemExists(T item){

    // }

    // TODO: better way to find item? binary sort tree?
    // DO I NEED THIS???
    public int getIndexOfItem(T item) {
      for (int i=0; i<array.Length; i++){
        if (array[i].Equals(item)){
          return i;
        }
      }
      throw new ItemNotFoundException();
    }
    public int getLength() {
      return array.Length;
    }

    public void Sort(){
      T[] sortedArray = new T[array.Length];

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
       return (IEnumerator) GetEnumerator();
    }

    public Enumerator<T> GetEnumerator() {
      return new Enumerator<T>(array);
    }
  }
}