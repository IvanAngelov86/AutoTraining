using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int reverse = 0;
            int number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                reverse = number % 10;
                Console.Write(reverse);
                number = number / 10;
            }
        }
    }
}
