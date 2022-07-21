using System;
using System.Collections.Generic;

namespace QuickSort
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<int> list = new List<int>() { 200, 5, 17, 4, 100, 12 }; 
            list = QuickSort(list);
            

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }

        private static List<int> QuickSort(List<int> arr)
        { 
            if (arr.Count <= 1)
            {
                return arr;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();
            List<int> result = new List<int>();
            
            int pivotIndex = arr.Count / 2;

            int pivot = arr[pivotIndex];


            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == pivot)
                {
                    continue;
                }

                if (arr[i] < pivot)
                {
                    left.Add(arr[i]);
                }

                else
                {
                    right.Add(arr[i]);
                }
            }

            result.AddRange(QuickSort(left));
            result.Add(pivot);
            result.AddRange(QuickSort(right));

            return result;
        }
    }
}
