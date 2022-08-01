using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDataStructures
{
    public class LinkedList<T>
    {
        public Node<T> Head;
        public int Count;
        public LinkedList()
        {
            Head = null;
            Count = 0;
        }

        //[45|2000]-->[98|3000]-->[3|NULL]
        //1000          2000        3000
        //
        //Head(!= 0 == prev)
        public int AddToTail(T input)
        {
            Node<T> newNode = new Node<T>(input);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<T> temp = Head;
                while (temp.Link != null)
                {
                    temp = temp.Link;
                }
                temp.Link = newNode;
            }
            return ++Count;
        }

        public int AddToHead(T input)
        {
            Node<T> newNode = new Node<T>(input);
            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Link = Head;
                Head = newNode;
            }
            return ++Count;
        }

        public bool Check(T input)
        {
            Node<T> temp = Head;
            while (temp != null)
            {
                if (temp.Data.Equals(input))
                {
                    return true;
                }
                temp = temp.Link;
            }
            return false;
        }

        public bool Remove(T input)
        {
            Node<T> temp = Head;
            while(temp != null)
            {
                if(temp.Data.Equals(input))
                {
                    Head = temp.Link;
                    Count--;
                    return true;
                }
                else if (temp.Link != null)
                {
                    if (temp.Link.Data.Equals(input))
                    {
                        temp.Link = temp.Link.Link;
                        Count--;
                        return true;
                    }
                }
                temp = temp.Link;
            }
            return false;
        }

        public int Index(T input)
        {
            Node<T> temp = Head;
            int index = 0;
            while(temp != null)
            {
                if (temp.Link.Equals(input))
                {
                    return index;
                }
                index++;
                temp = temp.Link;
            }
            return -1;
        }

        public void Print()
        {
            Node<T> temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Link;
            }
        }
    }
}
