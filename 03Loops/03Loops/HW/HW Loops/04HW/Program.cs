using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04HW
{
    class Program
    {
        static void Main()
        {
            Console.Write("How many numbers do you want to enter: ");
            int numbersCount = 0;
            int.TryParse(Console.ReadLine(), out numbersCount);
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int n = 0;
            int sum = 0;
            double average = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                Console.Write("Enter number: ");
                int.TryParse(Console.ReadLine(), out n);
                sum += n;
                average = (double)sum / numbersCount;
                if (n > maxValue)
                {
                    maxValue = n;
                }
                if (n < minValue)
                {
                    minValue = n;
                }
            }
            Console.WriteLine("Min value is: {0}.", minValue);
            Console.WriteLine("Max value is {0}.", maxValue);
            Console.WriteLine("The sum of all numbers is {0}.", sum);
            Console.WriteLine("The average of all numbers is {0:0.00}.", average);

        }
    }
}
