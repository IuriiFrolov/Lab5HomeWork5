using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
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
            Console.WriteLine("Заполните массив");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                   t[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            //Вывод 
            Console.WriteLine("Получен двумерный массив");
            int sumDiagonal1 = 0;
            int sumDiagonal2 = 0;
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                int sumStrochka = 0;
                int sumStolbik = 0;
               
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,3} ", t[i, j]);
                    sumStrochka += t[i, j];
                    sumStolbik += t[j, i];
                    if (i == j)
                    {
                        sumDiagonal1 += t[i, j];
                    }
                    if (i + j == n - 1)
                    {
                        sumDiagonal2 += t[i, j];
                    }
                }
                if (sumStrochka == sumStolbik && sumDiagonal1==sumDiagonal2 && sumStrochka == sumDiagonal1)
                {
                    flag = true;
                    
                }
                
                Console.WriteLine();
            }
            if (flag==true)
            {
                Console.WriteLine("Матрица является магическим квадратом!");
            }
            else Console.WriteLine("Матрица не является магическим квадратом");
            Console.ReadKey();
        }
    }
}
