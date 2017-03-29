using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demoNumbers = { 4, 5, 7, 3, 4, 5 };
            int[] emptyArray = new int[demoNumbers.Length];

            for (int i = 0; i < demoNumbers.Length; i++)
            {
                emptyArray[i] = demoNumbers[i] + 10;
                Console.Write(emptyArray[i] + ", ");
            }
        }
    }
}
