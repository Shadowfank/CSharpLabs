using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Function
    {
        public int s;
        public int F = 1;
        public void Factorial()
        {
            if (s <= 9 && s >= 1)
            {
                for (int c = s; c > 1; c--)
                    F = F * c;
                Console.WriteLine("Факторіал = {0}", F);
            }
            else
            {
                Console.WriteLine("Число не входить в діапазон чисел від 1 до 9");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Function task = new Function();
            Console.WriteLine("Введіть число");
            task.s = Convert.ToInt32(Console.ReadLine());
            task.Factorial();
            Console.ReadKey();
        }
    }
}
