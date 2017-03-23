using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13TextDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your number?");

            string Input = Console.ReadLine();

            if (Input.Contains(".") || Input.Contains(","))
            {
                Console.WriteLine("Trqbva da e cqlo chislo be katil!");
                   Main(args);
            }
            else
                {

                long number = long.Parse(Input);

                Console.WriteLine("The last digit is:");

                short last = (short)(number % 10);
                if (last == 0)
                {
                    Console.WriteLine("zero");
                    return;
                }
                if (last == 1)
                {
                    Console.WriteLine("one");
                    return;
                }
                if (last == 2)
                {
                    Console.WriteLine("dve");
                    return;
                }
                if (last == 3)
                {
                    Console.WriteLine("tri");
                    return;
                }
                if (last == 4)
                {
                    Console.WriteLine("four");
                    return;
                }
                if (last == 5)
                {
                    Console.WriteLine("five");
                    return;
                }
                if (last == 6)
                {
                    Console.WriteLine("six");
                    return;
                }
                if (last == 7)
                {
                    Console.WriteLine("seven");
                    return;
                }
                if (last == 8)
                {
                    Console.WriteLine("eight");
                    return;
                }
                else
                {
                    Console.WriteLine("nine");
                }
            }
        }
    }
}
