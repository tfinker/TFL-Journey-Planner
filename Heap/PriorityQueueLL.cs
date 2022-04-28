// using System;


// namespace Tutorial_9
// {

//     class PriorityQueue : LinkedList<QueueObject>
//     {


//       public void Enqueue(QueueObject newData){

//         if (Head == null){
//           InsertAtHead(newData);
//           return;
//         }

//         var currentNode = Head;
//         while(currentNode != null) {
//           var currentNodeData = (QueueObject) currentNode.Data; 

//           // need to check we are at start of list
//           if ( currentNode.Previous == null && newData.CompareTo(currentNodeData) < 0 ) {
//             InsertAtHead(newData);
//             return;
//           }

//           if ( currentNode.Next != null ) {

//             QueueObject nextNodeData = null;
//             nextNodeData = (QueueObject) currentNode.Next.Data;

//             if ( currentNodeData.CompareTo(newData) < 0 && newData.CompareTo(nextNodeData) <= 0 ) {
//               InsertAfterNode(currentNode, newData);
//               return;
//             }
//           }

//           if (currentNode.Next == null ) {
//             if ( currentNodeData.CompareTo(newData) <= 0 ) {
//               InsertAfterNode(currentNode, newData);
//               return;
//             }
//           } 

//           currentNode = currentNode.Next;
//         }
//       }

//       public QueueObject Dequeue() {
//         var obj = removeHead();
//         return (QueueObject) obj.Data;
//       }
//     }
// }