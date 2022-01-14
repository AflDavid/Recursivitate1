using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recc1
{
    public static class Recursiv
    {
        public static void PV(int[] vector, int n)
        {
            if (n == 1)
                Console.WriteLine(vector[n - 1]);
            else
            {
                PV(vector, n-1);
                Console.WriteLine(vector[n - 1]);
            }
        }
    }
}
