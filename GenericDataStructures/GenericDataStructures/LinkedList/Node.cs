using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDataStructures
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Link { get; set; }

        public Node(T data)
        {
            //[Data | Link] --> [Data | Link] --> [Data | Link] --> [Data | Link]
            //newNodeAddress = NodeLink
            Data = data;
            Link = null;
        }
    }
}
