using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDataStructures
{
    public class Queue<T>
    {
        private LinkedList<T> myLinkedList;

        public Queue()
        {
            myLinkedList = new LinkedList<T>();
        }

        public void Enqueue(T input)
        {
            myLinkedList.AddToTail(input);
        }

        public bool IsEmpty()
        {
            if (myLinkedList.Count == 0)
            {
                return true;
            }
            return false;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Empty Queue!, include an input to Dequeue.");
            }
            Node<T> newNode = myLinkedList.Head;
            myLinkedList.Remove(newNode.Data);
            return newNode.Data;
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
