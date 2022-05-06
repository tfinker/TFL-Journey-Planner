using System;
using System.Collections;

namespace LondonTube {
  
  class List<T> : IEnumerable { 

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

    private T RemoveIndexFromArray(int index){
      
      if (index >= array.Length){
        throw new IndexOutOfRangeException();
      } 
           
      T[] newArray = new T[array.Length-1];

      T item = array[index];

      if (index == 0){
        Array.Copy(array, index+1, newArray, index, newArray.Length );
      }
      else if ( index == array.Length-1 ){
        Array.Copy(array, 0, newArray, 0, index );
      }
      else if (index > 0 && index < array.Length-1) {
        Array.Copy(array, 0, newArray, 0, index );
        Array.Copy(array, index+1, newArray, index, array.Length - 1 - index );
      }

      array = newArray;
      return item;
    }

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
      return array[array.Length-1];
    }
    public T getItemAtIndex(int index) {
      if (array.Length == 0 || index >= array.Length){
        throw new IndexOutOfRangeException();
      }
      return array[index];
    }

    public T RemoveLast(){
      return RemoveItem(getLastItem());
    }

    public T RemoveItem( T item ){

      return RemoveIndexFromArray(getIndexOfItem(item));
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
      throw new IndexOutOfRangeException();
    }
    public int getLength() {
      return array.Length;
    }

    // public void Sort(){
    //   T[] sortedArray = new T[array.Length];

    // }

    public T this[int index]
      {
          get {
              if (index >= array.Length) {
                throw new IndexOutOfRangeException();
              }
              return getItemAtIndex(index);
          }
      }

    IEnumerator IEnumerable.GetEnumerator()
    {
       return (IEnumerator) GetEnumerator();
    }

    public ListEnumerator<T> GetEnumerator() {
      return new ListEnumerator<T>(array);
    }
  }
}