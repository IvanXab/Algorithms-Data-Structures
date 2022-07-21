using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
       

        public static void Main(string[] args)
        {
            List<int> list = new List<int>(30);

            ArrayOperation ao = new ArrayOperation();
            ao.FillList(list);
            ao.Eratoshen(list);
            ao.PrintList(list);
        }
    }
}
