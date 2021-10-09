using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 7 значений:");
            double[] array = new double[7];
            double sum = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine("Среднее арифметическое = {0:f2}", (sum/7));
            Console.ReadKey();
        }
    }
}
