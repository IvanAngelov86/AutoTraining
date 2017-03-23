using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 3rd number");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"The Largest is: {LargestOf2.GetMax(LargestOf2.GetMax(a, b), c)} MAAFAKA");
        }
    }
}
