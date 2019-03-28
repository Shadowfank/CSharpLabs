using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a, b, c, d;
            double F = 0, x, y;
            Console.WriteLine("Введіть значення a, b, c, d");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення x, y");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (a * x + b * y >= c && a * x + b * y < d)
            {
                F = a * x + b * y;
                Console.WriteLine("Виконується Перша умова, тому результат = " + F);
                Console.ReadLine();
            }
            else
            {
                if (a * x + b * y < c)
                {
                    F = x + y;
                    Console.WriteLine("Виконується Друга умова, тому результат = " + F);
                    Console.ReadLine();
                }
                else if (a * x + b * y >= d)
                {
                    F = 1 - x - y;
                    Console.WriteLine("Виконується Третя умова, тому результат = " + F);
                    Console.ReadLine();
                }
            }
        }
    }
}
