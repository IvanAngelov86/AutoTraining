using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ContinueLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[] { 0, 1, 1, 3, 5, 8, 13 };
            foreach (var item in myArr)
            {
                if (item == 3 || item == 5)
                {
                    Console.WriteLine("in the IF");
                    continue;
                }
                Console.WriteLine("continue");

            }
            Console.WriteLine("Outer line");
            Console.ReadLine();
        }
    }
}
