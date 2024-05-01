using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue
{
    class Arr_Queue
    {
        private int front;
        private int rear;
        private int[] arr;

        public Arr_Queue(int size)
        {
            arr = new int[size];
            front = 0;
            rear = -1;
        }

        public int[] elements()
        {
            return this.arr;
        }

        public void Enqueue(int x)
        {
            if (rear == arr.Length - 1)
            { // if Queue is full, print error             
                Console.WriteLine("Error: the Queue is full.");
            }
            else
            {
                rear++;
                arr[rear] = x;
            }
        }
        public int Dequeue()
        {
            if (front > rear)
            { //if stack is empty, print error
                Console.WriteLine("Error: the Queue is empty.");
                return -1;
            }
            else
            {
                int x = arr[front];
                front++;
                return x;
            }
        }

    };

    class Arr_list_Queue
    {
        private int front;
        private int rear;
        private ArrayList list;

        public Arr_list_Queue()
        {
            list = new ArrayList();
            front = 0;
            rear = -1;
        }

        public ArrayList elements()
        {
            return this.list;
        }

        public void Enqueue(int x)
        {
            rear++;
            list.Add(x);
        }

        public object Dequeue()
        {
            if (list.Count == 0 || front > rear)
            { //if stack is empty, print error
                Console.WriteLine("Error: the Queue is empty.");
                return -1;
            }
            else
            {
                object x = list[0];
                list.RemoveAt(0);
                return x;
            }
        }

    };

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
