using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n; double a = 0;
            Console.Write("Введіть n=");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                a = 3 - 3 * Math.Sin(Math.Pow(i, 2));
                Console.WriteLine("a={0}", a);
            }
            Console.ReadKey();
        }
    }
}
