using System;
using System.Collections;

namespace LondonTube
{

    class LinkedList<T> : ILinkedList<T>, IEnumerable {
      public LinkedListObject<T> Head {get;set;}
      public LinkedListObject<T> Tail {get;set;}
      public int Length {get;set;}

      public LinkedList() {
        Head = null;
        Length = 0;
      }

      public LinkedList(T obj) {
        Head = new LinkedListObject<T>(obj, null, null);
        Tail = Head;
        Length = 0;

      }

      public void InsertFirst(T data) {
        Head = new LinkedListObject<T>(data, null, Head);
        if (Head.Next != null)
          Head.Next.Previous = Head;
        if (Tail == null) {
          Tail = Head;
        }
        Length++;
      }

      public void InsertLast(T data) {
        Tail = new LinkedListObject<T>(data, Tail, null);
        if (Tail.Previous != null)
          Tail.Previous.Next = Tail;
        if (Head == null){
          Head = Tail;
        }
        Length++;
      }

      public void InsertAfterNode(LinkedListObject<T> node, T data) {

        if (node == null){
          throw new InvalidOperationException("Node can not be null");
        }

        var newNode = new LinkedListObject<T>(data, node, node.Next);

        if (node.Next != null) {
          node.Next.Previous = newNode;
        }

        node.Next = newNode;

        if (newNode.Next == null) {
          Tail = newNode;
        }

        Length++;
      }


      public void InsertAtIndex(T item, int index){

        if (index > Length){
           throw new IndexOutOfRangeException($"Index {index} more than Length {Length}");
        }

        if (index == 0){
          InsertFirst(item);
          return;
        }
        else if (index == Length){
          InsertLast(item);
          return;
        }
        else {
          InsertAfterNode(getItemAtIndex(index).Previous, item);
        }
      

      }

      public LinkedListObject<T> getItemAtIndex(int index){

        if (index >= Length){
           throw new IndexOutOfRangeException($"Index {index} greater than number of nodes {Length-1}");
        }
        
        var node = Head;
        int i = 0;
        while (node!=null){
          if (i==index){
            return node;
          }
          i++;
          node=node.Next;
        }

        throw new InvalidOperationException($"Could not find index {index}");

      }

      public LinkedListObject<T> findNode(T data){
        var node = Head;
        while(node != null) {
          if (node.Data.Equals(data)) 
            return node;
          node = node.Next;
        }
        return null;
      }
      
      public void RemoveItem(T data) {
        var node = findNode(data);

        if (node != null) {
          if (node.Previous != null){
            node.Previous.Next = node.Next;
          }
          if (node.Next != null){
            node.Next.Previous = node.Previous;
          }
          if (node == Head) {
            Head = node.Next;
          }
          if (node == Tail) {
            Tail = node.Previous;
          }
          node.Next = null;
          node.Previous = null;
          
          Length--;
        }
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        return (IEnumerator) GetEnumerator();
      }

      public LinkedListEnumerator<T> GetEnumerator() {
        return new LinkedListEnumerator<T>(this);
      }

    }

    
}
