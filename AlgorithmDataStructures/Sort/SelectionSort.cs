using System;

namespace SelectionSort { 
    
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

        public void swap(int first_index, int sec_index) {
            int temp = array[first_index];
            array[first_index] = array[sec_index];
            array[sec_index] = temp;
        }

        public int[] SelectionSort() {

            for (int i = 0; i < maxSize; i++) {
                int min = i;
                for (int j = i; j < maxSize; j++) {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                swap(i, min);
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
            ar.SelectionSort();
            ar.PrintArray();

        }
    }
}