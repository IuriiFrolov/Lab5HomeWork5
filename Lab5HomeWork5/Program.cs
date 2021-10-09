using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное значение N ");
            ushort N = Convert.ToUInt16(Console.ReadLine());

            int n = N;
            int m = N;
            int[,] t = new int[n, m];
         
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j % 2 == 0 && i % 2 == 0)
                    {
                        t[i, j] = 1;
                    }
                    else if (j % 2 == 1 && i % 2 == 1)
                    {
                        t[i, j] = 1;
                    }
                    else if (j % 2 == 0 && i % 2 == 1)
                    {
                        t[i, j] = 0;
                    }
                    else t[i, j] = 0;
                   
                    Console.Write("{0,2} ", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
