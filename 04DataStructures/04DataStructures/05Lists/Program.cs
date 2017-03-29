using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<DOg> Doggies = new List<DOg>();

            DOg Pes = new DOg();
            Pes.Name = "Pes";
            DOg Roko = new DOg();
            Roko.Name = "Roko";
            DOg Misho = new DOg();

            Doggies.Add(Pes);
            Doggies.Add(Roko);
            Doggies.Add(Misho);

            for (int dog = 0; dog < Doggies.Count; dog++)
            {
                if (dog/2 == 0)
                {
                    Doggies[dog].Fur = "short";
                }
                else
                {
                    Doggies[dog].Fur = "long";
                }
                Console.WriteLine(dog);
                Console.WriteLine(Doggies[dog].Fur);
                Console.WriteLine(Doggies[dog].Name);

            }
            }

        }
    }
}
