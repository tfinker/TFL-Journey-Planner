using System;
using System.Collections;

namespace Tutorial_9
{

    class LinkedList<T> {
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

      public void InsertAtHead(T data) {
        Head = new LinkedListObject<T>(data, null, Head);
        if (Head.Next != null)
          Head.Next.Previous = Head;
        if (Head.Next == null) {
          Tail = Head;
        }
        Length++;
      }

      public void InsertAtTail(T data) {
        Tail = new LinkedListObject<T>(data, Tail, null);
        if (Tail.Previous != null)
          Tail.Previous.Next = Tail;
        Length++;
      }

      public void InsertAfterNode(LinkedListObject<T> node, T data) {
        var newNode = new LinkedListObject<T>(data, node, node.Next);
        if (node.Next != null)
          node.Next.Previous = newNode;
        node.Next = newNode;
        if (newNode.Next == null) {
          Tail = newNode;
        }
        Length++;
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
      
      public void removeData(T data) {
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

      public LinkedListObject<T> removeHead(){
        var returnObject = Head;
        Head = Head.Next;
        if (Head != null)
          Head.Previous = null;
        returnObject.Next = null;
        Length--;

        return returnObject;
      }



    }
    class LinkedListObject<T>
    {
        public T Data {get; set;}
        public LinkedListObject<T> Previous {get; set;}
        public LinkedListObject<T> Next {get; set;}
       

        public LinkedListObject(T data, LinkedListObject<T> previous, LinkedListObject<T> next) {
          this.Data = data;
          this.Previous = previous;
          this.Next = next;
        }

        // public void Print()
        // {
        //     Console.WriteLine("AlO[ Source: " + Source.ToString() + ", Target: " + Target.ToString()  + ", Weight: " + Weight +" ]");
        // }

    } // AlObject	
}
