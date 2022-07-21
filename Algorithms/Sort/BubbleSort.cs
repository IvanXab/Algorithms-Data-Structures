using System;

namespace BubbleSort { 
    
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

        public int[] BubbleSort() {
            for (int i = 0; i < maxSize; i++)
                for (int j = 0; j < maxSize - 1; j++) {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
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
            ar.BubbleSort();
            ar.PrintArray();

        }
    }
}