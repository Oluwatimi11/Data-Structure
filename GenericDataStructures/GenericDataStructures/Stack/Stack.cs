using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDataStructures
{
    public class Stack<T>
    {
        private LinkedList<T> myLinkedList;

        public Stack()
        {
            myLinkedList = new LinkedList<T>();
        }

        public bool IsEmpty()
        {
            return myLinkedList.Count == 0;
        }

        public void Push(T input)
        {
            myLinkedList.AddToHead(input);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("You have an empty Stack!, kindly input some items to apply the Pop function.");
            }
            Node<T> newNode = myLinkedList.Head;
            myLinkedList.Head = myLinkedList.Head.Link;
            myLinkedList.Count--;
            return newNode.Data;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("You have an empty Stack!, kindly input some items to apply the Peek function.");
            }
            return myLinkedList.Head.Data;
        }

        public int Size()
        {
            return myLinkedList.Count;
        }

        public void Print()
        {
            Node<T> temp = myLinkedList.Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Link;
            }
        }
    }
}
