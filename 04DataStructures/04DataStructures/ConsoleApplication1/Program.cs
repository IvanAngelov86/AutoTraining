using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demoNumbers = {4, 5, 7, 3, 4, 5};
            for (int i = 0; i < demoNumbers.Length; i++)
            {
                Console.WriteLine("Element {0} = {1}", i, demoNumbers[i]);
            }
            Console.WriteLine("BOOOOOOK");
        }
    }
}
