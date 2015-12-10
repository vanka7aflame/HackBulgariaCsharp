using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    public class Stack<T>
    {
        private LinkedList<T> newList = new LinkedList<T>();
        public Stack(LinkedList<T> stackList)
        {
            this.newList = stackList;
        }

        public T Peek()
        {
            return newList.Last();
        }
        public T Pop()
        {
            T last = newList.Last();
            newList.RemoveLast();
            return last;
        }
        public void Push(T item)
        {
            newList.AddLast(item);
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
        
    }
}
