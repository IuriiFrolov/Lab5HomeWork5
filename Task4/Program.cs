using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Random
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            #endregion
            int na = 0;
            for (int i = 1; i < 20; i+=2)
            {
                if (array[i] > 0)
                {
                    if (array[i] % 2 ==1)
                    {
                        na++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах = {0} ", na);
            Console.ReadKey();
        }
    }
}
