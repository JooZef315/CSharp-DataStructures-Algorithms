using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    class Program
    {
        static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length - i; j++)
                {
                    // swap adjacent out-of-order elements
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // find index of smallest element
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }

                }
                // swap smallest element with arr[i]
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            return arr;
        }

        static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i;
                while (j > 0 && arr[j - 1] > temp)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = temp;
            }
            return arr;
        }

        private static void RecMergeSort(int[] tempArray, int[] arr, int lbound, int ubound)
        {
            //base case
            if (lbound == ubound)
            {
                return;
            }
            int mid = (lbound + ubound) / 2;
            RecMergeSort(tempArray, arr, lbound, mid);
            RecMergeSort(tempArray, arr, mid + 1, ubound);
            Merge(tempArray, arr, lbound, mid + 1, ubound);

        }
        public static void Merge(int[] tempArray, int[] arr, int lowp, int highp, int ubound)
        {
            int lbound = lowp;
            int mid = highp - 1;
            int j = 0; // Initialize j here
            int n = (ubound - lbound) + 1;
            while ((lowp <= mid) && (highp <= ubound))
            {
                if (arr[lowp] < arr[highp])
                {
                    tempArray[j] = arr[lowp];
                    j++;
                    lowp++;
                }
                else
                {
                    tempArray[j] = arr[highp];
                    j++;
                    highp++;
                }
            }
            while (lowp <= mid)
            {
                tempArray[j] = arr[lowp];
                j++;
                lowp++;
            }
            while (highp <= ubound)
            {
                tempArray[j] = arr[highp];
                j++;
                highp++;
            }
            for (j = 0; j < n; j++)
            {
                arr[lbound + j] = tempArray[j];
            }
        }


        static void Main(string[] args)
        {
            //int[] x1 = BubbleSort(arr);
            //int[] x2 = SelectionSort(arr);
            //int[] x3 = InsertionSort(arr);
            //RecMergeSort(tempArray, arr, 0, tempArray.Length - 1);
          
            Console.ReadKey();
        }
    }
}
