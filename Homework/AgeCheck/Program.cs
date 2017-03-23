using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte Age;

                        bool loop = true;

            Console.WriteLine("Napishi si vuzrastta molim!");

            while (loop)
            {
                Age = sbyte.Parse(Console.ReadLine());
                if (Age >= 18 && Age <= 80)
                {
                    Console.WriteLine("Bravo");
                    loop = false;
                }

                else if (Age >= 16 && Age < 18)
                {
                    Console.WriteLine("Mlad si oshte");
                    loop = false;
                }

                else if (Age > 80)
                {
                    Console.WriteLine("Tvurde star si. Probvai pak!!");

                }

                else if (Age < 16)
                {
                    Console.WriteLine("Maika ti znae li che si igraesh s kompa?!\nIzlaji che si po-star!");
                }
            }
        }
    }
}
