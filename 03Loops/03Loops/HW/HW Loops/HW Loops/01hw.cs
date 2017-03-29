using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All numbers till:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The numbers are:\n");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
