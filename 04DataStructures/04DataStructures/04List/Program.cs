using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04List
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dzzverove = new Dictionary<string, int>();
            dzzverove.Add("cat", 23);
            dzzverove.Add("cat2", 3);
            dzzverove.Add("cat3", 4);
            dzzverove.Add("cat4", 14);
            dzzverove.Add("cat5", 24);
            dzzverove.Add("cat6", 34);

            foreach (var key in dzzverove.Keys)
            {
                Console.WriteLine(key);
            }
            
        }
    }
}
