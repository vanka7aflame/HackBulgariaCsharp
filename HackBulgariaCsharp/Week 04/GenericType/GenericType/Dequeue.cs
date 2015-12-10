using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    public class Dequeue<T>
    {
        private LinkedList<T> newList = new LinkedList<T>();

        public Dequeue(LinkedList<T> inputList)
        {
            this.newList = inputList;
        }

        public void Clear()
        {
            newList.Clear();
        }
        public bool Contains(T item)
        {
            if (newList.Contains(item))
            {
                return true;
            }
            return false;
        }
        public T RemovesFromFront()
        {
            T first = newList.First();
            newList.RemoveFirst();
            return first;
        }
        public T RemovesFromEnd()
        {
            T last = newList.Last();
            newList.RemoveLast();
            return last;
        }
        public void AddToFront(T item)
        {
            newList.AddFirst(item);
        }
        public void AddToEnd(T item)
        {
            newList.AddLast(item);
        }
        public T PeekFromFront()
        {
            return newList.First();
        }
        public T PeekFromEnd()
        {
            return newList.Last();
        }
    }
}
