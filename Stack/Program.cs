using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class Arr_Stack
    {
        private int top;
        private int[] arr;
        
        public Arr_Stack(int size)
        {
            arr = new int[size];            
            top = -1;
        }

        public int[] elements()
        {
            return this.arr;
        }

        public void Push(int x)
        {
            if (top == arr.Length - 1)  // if stack is full, print error
                Console.WriteLine("Error: the stack is full.");
            else
            {
                top++;
                arr[top] = x;
            }
        }
        
        public int Pop()
        {
            if (top == -1)
            { //if stack is empty, print error
                Console.WriteLine("Error: the stack is empty.");
                return -1;
            }
            else
            {
                int x = arr[top];
                top--;
                return x;
            }
        }

    };

    class Arr_list_Stack
    {
        private int top;
        private ArrayList list;
        
        public Arr_list_Stack()
        {
            list = new ArrayList();
            top = -1;
        }

        public ArrayList elements()
        {
            return this.list;
        }


        public void Push(object x)
        {
            top++;
            list.Add(x);
        }
        public object Pop()
        {
            if (top == -1)
            { //if stack is empty, print error
                Console.WriteLine("Error: the stack is empty.");
                return -1;
            }
            else
            {
                object x = list[top];
                list.RemoveAt(top);
                top--;
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
