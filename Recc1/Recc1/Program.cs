using System;

namespace Recc1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[] { 5, 6, 7, 8, 9, 10 };
            Recursiv.PV(vector, vector.Length);
        }
    }
}
