using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05multipleLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("1st Loop");
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("2nd Loop");
                }
                Console.WriteLine("3rd Loop");
            }
            Console.WriteLine("Outside all");
            Console.ReadLine();
        }
    }
}
