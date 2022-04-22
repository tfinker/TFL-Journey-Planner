using System;

namespace Tutorial_9
{

    class MinHeap<T> : Heap<T> where T : IComparable<T>
    {

      private int getLastIndex(){
        return heap.Length-1;
      }
      
      override public void InsertItem(T item){
          addToHeap(item);
          BubbleUp(getLastIndex());
          
      }

      override public T RemoveHead() {
        int headIndex = 1;
        swapItems(headIndex, getLastIndex());
        var head = removeFromHeap(getLastIndex());
        BubbleDown(headIndex);

        return head;
      }

      private void addToHeap(T item) {
        Array.Resize(ref heap, heap.Length+1);
        heap[getLastIndex()]=item;
        Length+=1;
      }

      private T removeFromHeap(int index){
        var item = heap[index];
        Array.Resize(ref heap, heap.Length-1);
        Length--;
        return item;
      }

      private void BubbleUp(int childIndex){
        if (childIndex <= 1) {
          return;
        }

        var parentIndex = getParentIndex(childIndex);

        if (isChildHigherPriority(parentIndex, childIndex)) {
          swapItems(parentIndex, childIndex);
          BubbleUp(parentIndex);
        }
      }

      private void BubbleDown(int parentIndex){
        var leftChildIndex = getLeftChildIndex(parentIndex);
        var rightChildIndex = getRightChildIndex(parentIndex);

        if (leftChildIndex > getLastIndex()){
          return;
        }

        if (rightChildIndex > getLastIndex()){
          if (isChildHigherPriority(parentIndex, leftChildIndex)) {
            swapItems(parentIndex, leftChildIndex);
          }
          return;
        }

        var highestPriorityIndex = getHighestPriorityIndex(parentIndex, leftChildIndex, rightChildIndex);

        if (parentIndex == highestPriorityIndex) {
          return;
        }
        swapItems(parentIndex, highestPriorityIndex);
        BubbleDown(highestPriorityIndex);
      }

      private bool isChildHigherPriority(int parentIndex, int childIndex){
        if (heap[parentIndex].CompareTo(heap[childIndex]) < 0){
          return true;
        }
        else {
          return false;
        }
      }

      private int getHighestPriorityIndex(int parentIndex, int leftIndex, int rightIndex){
        var isLeftHigher = isChildHigherPriority(parentIndex, leftIndex);
        var isRightHigher = isChildHigherPriority(parentIndex, rightIndex);

        if (isLeftHigher && isRightHigher){
          return getHigherPriorityIndex(leftIndex, rightIndex);
        }
        else if (isLeftHigher) {
          return leftIndex;
        }
        else if (isRightHigher) {
          return rightIndex;
        }
        else {
          return parentIndex;
        }

      }

      private int getHigherPriorityIndex(int leftIndex, int rightIndex){
        if(heap[leftIndex].CompareTo(heap[rightIndex]) > 0){
          return leftIndex;
        }
        else {
          return rightIndex;
        }
      }

      private void swapItems(int item1, int item2){
        var swapItem = heap[item2];
        heap[item2] = heap[item1];
        heap[item1] = swapItem;
      }
      
      
      private int getParentIndex(int childIndex){
        if ( childIndex % 2 == 0){
          return childIndex / 2;
        }
        else {
          return (childIndex-1) / 2;
        }

      }

      private int getLeftChildIndex(int parentIndex){
        return parentIndex * 2;
      }

      private int getRightChildIndex(int parentIndex){
        return (parentIndex * 2) + 1;
      }
    }
}