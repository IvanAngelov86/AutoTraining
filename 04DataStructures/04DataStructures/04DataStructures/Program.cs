using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibArray = new int[] { 0, 1, 1, 2, 3, 5 };
            foreach (int element in fibArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
