using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    public static class LargestOf2
    {
        public static int GetMax(int a,int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
