using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = -3;
            while (i >= -3 && i <= 2)
            {
                double y = 3-3*Math.Sin(Math.Pow(i, 2));
                Console.WriteLine("Значення виразу при i " + i + " буде " + y);
                i = i + 0.1;
            }
            Console.ReadKey();
        }
    }
}
