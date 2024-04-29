using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggestValueInArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 905, 26, -2147483648, 90, 14, 10000010, 0 };

            Console.WriteLine("Minimum number is " + arr.Min());
            Console.WriteLine("Maximum number is " + arr.Max());
        }
    }
}
