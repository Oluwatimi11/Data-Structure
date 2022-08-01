using System;
using System.Collections.Generic;

namespace GenericDataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<string> listItem = new Queue<string>();
            listItem.Enqueue("a");
            listItem.Enqueue("b");
            listItem.Enqueue("c");
            listItem.Enqueue("d");

            listItem.Print();
        }
    }
}