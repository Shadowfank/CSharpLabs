using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a, b, c;
            Console.WriteLine("Введіть значення змінної a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення змінної b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення змінної c");
            c = double.Parse(Console.ReadLine());
            if (a > b)
            {
                double sum = Math.Pow((a + b + c), 2);
                Console.WriteLine("a > b, тому значення додавання =" + sum);
                Console.ReadLine();
            }
            else
            {
                double dobutok = Math.Pow((a * b * c), 2);
                Console.WriteLine("a < b, тому значення добутку =" + dobutok);
                Console.ReadLine();
            }
        }
    }
}
