using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] mas = new int[10];
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("mas[{0}]=", i);
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(Acts.Sum(mas));
            Console.WriteLine(Acts.Dobutok(mas));
            Console.WriteLine(Acts.Sort(mas));
            Console.ReadKey();
        }
    }
    class Acts
    {
        public static string Sum(int[] mas)
        {
            string result;
            int sum = 0;
            for (int i = mas.Length - 1; i >= 0; i--)
            {
                if (mas[i] < 0)
                {
                    sum = mas[i] + sum;
                }
            }
            result = "Сума від'ємних елементів = ";
            result = result + sum;
            return result;
        }


        public static string Dobutok(int[] mas)
        {
            string result = "Добуток = ";
            int max = mas[0];
            int min = mas[0];
            int maxID = 0; int minID = 0;
            int Dobutok = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                    maxID = i;
                }
                else
                if (mas[i] < min)
                {
                    min = mas[i];
                    minID = i;
                }
            }
            if (minID == maxID)
            {
                result += "0";
            }
            else
            if (maxID > minID)
            {
                for (int i = minID + 1; i < maxID; i++)
                {
                    Dobutok *= mas[i];
                }
                result += Dobutok;
            }
            else
            if (minID > maxID)
            {
                for (int i = maxID + 1; i < minID; i++)
                {
                    Dobutok *= mas[i];
                }
                result += Dobutok;
            }
            return result;
        }
        public static string Sort(int[] mas)
        {
            string result = "";
            int temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            //вивід
            Console.Write("Відсортований масив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]);
                Console.Write(" ");
            }
            Console.ReadLine();
            return result;
        }
    }
}
