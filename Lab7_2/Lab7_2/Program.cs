using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Program
    {
        static void Main()
        {
            /*Console.Write("Введите число: ");
            string str = Console.ReadLine();

            int x = Convert.ToInt32(str);

            int counter = 0;

            while (x > 0)
            {
                    counter++;
                    x = x / 10;
                    Console.WriteLine(x);
            }

            Console.WriteLine("Данное число содержит цифр: " + counter);
            Console.ReadKey();*/
            Console.Write("Введіть число ");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            while (n != 0)
            {
                s = s + n % 10;
                Console.WriteLine(n);
                n = n / 10;
            }
            Console.WriteLine("Сума чисел дорівнює: {0}", s);
            Console.ReadKey();
        }

    }
}
