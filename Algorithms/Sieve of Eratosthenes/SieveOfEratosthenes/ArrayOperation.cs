using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    public class ArrayOperation
    {
       public void FillList(List<int> list) 
       {
            for (int i = 2; i < 30; i++)
            {
                list.Add(i);
            }
       }

        public void PrintList(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }

        public void Eratoshen(List<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                for (int j = 2; j < 30; j++)
                {
                    list.Remove(list[i] * j);
                }
            }
        }
    }
}
