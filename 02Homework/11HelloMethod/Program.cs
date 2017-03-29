using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11HelloMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();

        }

        private static void SayHello()
        {
            string Name;

            Console.WriteLine("What is the Name of You dude?");

            Name = Console.ReadLine();

            Console.WriteLine("Hello, " + Name);
        }
    }
}
