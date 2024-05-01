using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Program
    {
        public class Node
        {
            public int Element; // Data stored in the node
            public Node FLink; // Reference to the next node in the list
            public Node BLink; // Reference to the previous node in the list
            public Node()
            {
                Element = 0;
                FLink = null;
                BLink = null;
            }
            // Constructor to initialize a node with data
            public Node(int element)
            {
                Element = element;
                FLink = null;
                BLink = null;
            }
        }

        public class DoubleLinkedList
        {
            protected Node header;
            // Constructor
            public DoubleLinkedList()
            {
                header = new Node(0);
            }

            private Node find(int item)
            {
                Node current = header;
                while (current != null && current.Element != item)
                {
                    current = current.FLink;
                }
                return current;
            }
            public void insert(int newItem, int after)
            {
                Node newNode = new Node(newItem);
                Node current = find(after);
                if (current != null)
                {
                    if (current.FLink != null)
                    {
                        newNode.FLink = current.FLink;
                        current.FLink.BLink = newNode;
                    }
                    newNode.BLink = current;
                    current.FLink = newNode;
                }
            }

            public void remove(int item)
            {
                Node currentItem = find(item);

                if (currentItem != null)
                {
                    if (currentItem.FLink != null)
                    {
                        currentItem.FLink.BLink = currentItem.BLink;
                    }

                    currentItem.BLink.FLink = currentItem.FLink;
                    currentItem.FLink = null;
                    currentItem.BLink = null;
                }
            }

            public Node findLast()
            {
                Node current = new Node();
                current = header;
                while (current.FLink != null)
                {
                    current = current.FLink;
                }
                return current;
            }

            public void PrintList()
            {
                Node current = header;
                while (current != null)
                {
                    Console.WriteLine(current.Element);
                    current = current.FLink;
                }
            }


            public void printReverse()
            {
                Node current = findLast();
                while (current != null)
                {
                    Console.WriteLine(current.Element);
                    current = current.BLink;
                }
            }

            public bool IsEmpty() { return (header.FLink == null); }

        }


        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
