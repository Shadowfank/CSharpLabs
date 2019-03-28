using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть перше число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Результат додавання: {0}", c);
            Console.ReadKey();
        }
    }
}
