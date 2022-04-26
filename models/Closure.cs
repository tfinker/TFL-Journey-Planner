using System;

namespace Tutorial_9 {
  class Closure {

    LinkedList elements;

    public Closure(){
      elements = new LinkedList();
    }

    public void addElement(Connection connection){
      elements.InsertAtTail(connection);
    }


  }

}
