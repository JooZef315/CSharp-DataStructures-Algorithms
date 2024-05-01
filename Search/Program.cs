using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Search
{
    class Program
    {
        static int BinarySearch(int[] a, int value)
        {
            int low = 0, high = a.Length - 1, mid;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (value == a[mid])
                    return mid;
                else if (value < a[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }


        static int SeqSearch(int[] a, int sValue)
        {
            int i;
            for (i = 0; i < a.Length - 1; i++)
                if (a[i] == sValue) return i;
            return -1;
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
