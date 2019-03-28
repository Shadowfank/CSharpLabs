using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Console.InputEncoding = Encoding.GetEncoding(1251);
            double t;
            double x = 14.26;
            double z = 0.2;
            Console.WriteLine("Введіть число x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть число z");
            z = Convert.ToDouble(Console.ReadLine());
            t = 1 + (x + (Math.Pow(x, 2)) / (3 - Math.Pow(z, 2)));
            Console.WriteLine("Результат = {0}", t);
            Console.ReadKey();
        }
    }
}
