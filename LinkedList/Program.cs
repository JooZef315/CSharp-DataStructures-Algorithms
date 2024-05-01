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
            public Node Link; // Reference to the next node in the list

            public Node()
            {
                Element = 0;
                Link = null;
            }
            // Constructor to initialize a node with data
            public Node(int element)
            {
                Element = element;
                Link = null;
            }
        }

        public class LinkedList
        {
            protected Node header;
            // Constructor
            public LinkedList()
            {
                header = new Node(0);
            }

            private Node find(int item)
            {
                Node current = header;
                while (current != null && current.Element != item)
                {
                    current = current.Link;
                }
                return current;
            }

            public void insert(int newItem, int after)
            {
                Node newNode = new Node(newItem);
                Node current = find(after);
                if (current != null)
                {
                    newNode.Link = current.Link;
                    current.Link = newNode;
                }
            }

            private Node findPrevious(int n)
            {
                Node current = header;
                while (current != null && current.Link != null && current.Link.Element != n)
                {
                    current = current.Link;
                }
                return current;
            }

            public void remove(int item)
            {
                Node Previousitem = findPrevious(item);
                if (Previousitem != null && Previousitem.Link != null)
                {
                    Previousitem.Link = Previousitem.Link.Link;
                }
            }

            public void PrintList()
            {
                Node current = new Node();
                current = header;
                while (current != null)
                {
                    Console.WriteLine(current.Element);
                    current = current.Link;
                }
            }
            public bool IsEmpty() { return (header.Link == null); }

        }



        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
