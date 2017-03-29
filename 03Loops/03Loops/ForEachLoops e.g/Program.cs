using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoops_e.g
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[] { 0, 1, 1, 3, 5, 8, 13 };
            foreach (var item in myArr)
            {
                if (item ==3)
                {
                    Console.WriteLine("element found");
                    break;
                }
                Console.WriteLine("out of if");
                
            }
            Console.WriteLine("first part  ");
            Console.ReadLine();
        }
    }
}
