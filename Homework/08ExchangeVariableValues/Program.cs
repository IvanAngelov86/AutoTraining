using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 7;
            int number2 = 33;

            Console.WriteLine("Before: number1={0}\tnumber2={1}", number1, number2);

            int TempNumber;

            TempNumber = number1;
            number1 = number2;
            number2 = TempNumber;

            Console.WriteLine("After: number1={0}\tnumber2={1}", number1, number2);

        }
    }
}
