using System;

namespace Search {
    
    class Sort {
        
        private int[] array;
        private int maxSize;
        private int item = 0;
            
        public Sort(int size) {
            maxSize = size;
            array = new int[maxSize];
        }
        
        public void InsertInArray(int value) {
            array[item] = value;
            item++;
        }

        public void PrintArray() {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }

        public bool LinearSearch(int key) {
            for (int i = 0; i < maxSize; i++) {
                if (array[i] == key)
                    return true;
            }
            return false;
        }

        public int BinarySearch(int key)
        {
            int start = 0;
            int end = array.Length;
            int middle = 0;
            bool flag = false;
            int posititon = -1;

            while (flag == false && start <= end) {
                
                middle = (start + end) / 2;

                if (array[middle] == key) {
                    flag = true;
                    posititon = middle;
                    return middle;
                }

                if (array[middle] > key) {
                    end = middle - 1;
                }
                
                else {
                    start = middle + 1;
                }
            }
            return posititon;
        }
        
        }
    
    class Program
    {
        static void Main(string[] args)
        {
            Sort ar = new Sort(6);
            
            ar.InsertInArray(1);
            ar.InsertInArray(2);
            ar.InsertInArray(3);
            ar.InsertInArray(4);
            ar.InsertInArray(5);
            ar.InsertInArray(6);

            Console.WriteLine(ar.LinearSearch(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine(ar.BinarySearch(3));
            
            ar.PrintArray();
           

        }
    }
}