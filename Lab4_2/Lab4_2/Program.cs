using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a;
            double h;
            Console.Write("Введіть одну з сторін трикутника та висоту, опущену на неї \r\nСторона трикутника = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Висота трикутника = ");
            h = Convert.ToDouble(Console.ReadLine());
            double S = 0.5 * a * h;
            Console.WriteLine("Площа трикутника = " + S);
            Console.ReadKey();
        }
    }
}
