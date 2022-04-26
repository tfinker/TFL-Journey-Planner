using System;

namespace Tutorial_9
{

    class LinkedList {
      public LinkedListObject Head {get;set;}
      public LinkedListObject Tail {get;set;}
      public int Length {get;set;}

      public LinkedList() {
        Head = null;
        Length = 0;
      }

      public LinkedList(Object obj) {
        Head = new LinkedListObject(obj, null, null);
        Tail = Head;
        Length = 0;

      }

      public void InsertAtHead(Object data) {
        Head = new LinkedListObject(data, null, Head);
        if (Head.Next != null)
          Head.Next.Previous = Head;
        if (Head.Next == null) {
          Tail = Head;
        }
        Length++;
      }

      public void InsertAtTail(Object data) {
        Tail = new LinkedListObject(data, Tail, null);
        if (Tail.Previous != null)
          Tail.Previous.Next = Tail;
        Length++;
      }

      public void InsertAfterNode(LinkedListObject node, Object data) {
        var newNode = new LinkedListObject(data, node, node.Next);
        if (node.Next != null)
          node.Next.Previous = newNode;
        node.Next = newNode;
        if (newNode.Next == null) {
          Tail = newNode;
        }
        Length++;
      }


      public LinkedListObject findNode(Object data){
        var node = Head;
        while(node != null) {
          if (node.Data.Equals(data)) 
            return node;
          node = node.Next;
        }
        return null;
      }
      
      public void removeData(Object data) {
        var node = findNode(data);

        if (node != null) {
          node.Previous.Next = node.Next;
          node.Next.Previous = node.Previous;
          node.Next = null;
          node.Previous = null;
        }

        Length--;
      }

      public Object removeHead(){
        var returnObject = Head;
        Head = Head.Next;
        if (Head != null)
          Head.Previous = null;
        returnObject.Next = null;
        Length--;

        return returnObject;
      }

    }
    class LinkedListObject 
    {
        public Object Data {get; set;}
        public LinkedListObject Previous {get; set;}
        public LinkedListObject Next {get; set;}
       

        public LinkedListObject(Object data, LinkedListObject previous, LinkedListObject next) {
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
