using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{

    public class Node
    {
        public int Data; // Data stored in the node
        public Node left;
        public Node right;

        // Constructor to initialize a node with data
        public Node(int data)
        {
            Data = data;
            left = null;
            right = null;
        }

        public void displayNode()
        {
            Console.WriteLine(Data);
        }

    }

    public class BTree
    {
        Node Root;
        static int count = 0;

        public BTree()
        {
            Root = null;
        }


        public Node addNode(int data)
        {
            Node newNode = new Node(data);
            if (Root == null)
            {
                Root = newNode;
            }
            count++;
            return newNode;
        }

        public void insertNode(Node root, Node newNode)
        {
            Node temp = root;
            if (newNode.Data < temp.Data)
            {
                if (temp.left == null)
                {
                    temp.left = newNode;
                }
                else
                {
                    temp = temp.left;
                    insertNode(temp, newNode);
                }
            }
            else if (newNode.Data > temp.Data)
            {
                if (temp.right == null)
                {
                    temp.right = newNode;
                }
                else
                {
                    temp = temp.right;
                    insertNode(temp, newNode);
                }
            }
        }

        public void printTreeCount()
        {
            Console.WriteLine("count: " + count);
        }




        public void traverseTreeInOrder(Node root)
        {
            Node temp = root;

            if (temp == null)
            {
                return;
            }

            traverseTreeInOrder(temp.left);
            temp.displayNode();
            traverseTreeInOrder(temp.right);
        }

        public void traverseTreePostOrder(Node root)
        {
            Node temp = root;

            if (temp == null)
            {
                return;
            }

            traverseTreePostOrder(temp.left);
            traverseTreePostOrder(temp.right);
            temp.displayNode();
        }

        public void traverseTreePreOrder(Node root)
        {
            Node temp = root;

            if (temp == null)
            {
                return;
            }

            temp.displayNode();
            traverseTreePreOrder(temp.left);
            traverseTreePreOrder(temp.right);
        }







        public Node find(int key)
        {
            Node current = Root;
            while (current != null && current.Data != key)
            {
                if (key < current.Data)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }

            }
            return current;
        }

        public Node findParent(int key)
        {
            Node current = Root;
            while (current != null && current.left.Data != key && current.right.Data != key)
            {
                if (key < current.Data)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }

            }
            return current;
        }










        public Node DeleteNode(Node root, int key)
        {
            // Base case
            if (root == null)
                return root;

            // Recursive case
            if (key < root.Data)
                root.left = DeleteNode(root.left, key);
            else if (key > root.Data)
                root.right = DeleteNode(root.right, key);
            else
            {
                // Node with only one child or no child
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;

                // Node with two children: Get the inorder successor (smallest in the right subtree)
                root.Data = findMin(root.right);
                // Delete the inorder successor
                root.right = DeleteNode(root.right, root.Data);
            }

            return root;
        }

        public int findMin(Node root)
        {
            Node current = root;
            while (current.left != null)
                current = current.left;

            return current.Data;
        }

        public int findMax(Node root)
        {
            Node current = root;
            while (current.right != null)
                current = current.right;

            return current.Data;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            BTree bt = new BTree();
            Node root = bt.addNode(70);

            bt.insertNode(root, bt.addNode(80));
            bt.insertNode(root, bt.addNode(50));
            bt.insertNode(root, bt.addNode(62));
            bt.insertNode(root, bt.addNode(25));
            bt.insertNode(root, bt.addNode(74));
            bt.insertNode(root, bt.addNode(85));



            Console.WriteLine("min value: " + bt.findMin(root));
            Console.WriteLine("max value: " + bt.findMax(root));
            bt.printTreeCount();

            Node x = bt.DeleteNode(root, 50);

            Console.WriteLine("InOrder: ");
            bt.traverseTreeInOrder(root);
            Console.WriteLine("PostOrder: ");
            bt.traverseTreePostOrder(root);
            Console.WriteLine("PreOrder: ");
            bt.traverseTreePreOrder(root);

            Console.ReadKey();

        }

    }

}


