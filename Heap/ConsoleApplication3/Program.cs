using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var adr = new MaxMinBinaryHeap<int>();
            adr.HeapBuilder(true, 8,5,2,3,1,4,9,6,0,7);
            
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(adr.Extract(true));
            }                
            Console.ReadLine();
        }
    }
}
