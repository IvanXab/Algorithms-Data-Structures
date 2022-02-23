using System;

namespace InsertSort { 
    
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
        

        public int[] InsertSort() {
            int x;
            for (int i = 0; i < maxSize; i++) {
                x = array[i];
                int j = i;

                while (j > 0 && array[j - 1] > x) {
                    array[j] = array[j - 1];
                    j -= 1;
                }
                array[j] = x;
            }

            return array;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Sort ar = new Sort(5);
            
            ar.InsertInArray(777);
            ar.InsertInArray(7);
            ar.InsertInArray(1);
            ar.InsertInArray(-4);
            ar.InsertInArray(0);
            
            ar.PrintArray();
            Console.WriteLine();
            ar.InsertSort();
            ar.PrintArray();

        }
    }
}