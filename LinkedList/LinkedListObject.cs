using System;

namespace LondonTube {
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


    } 	
}