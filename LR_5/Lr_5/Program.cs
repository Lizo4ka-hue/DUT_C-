using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы NxM");
            int n, m, i, j;
            bool priz = true;
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("M = ");
            m = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, m];Random rnd = new Random();
            Console.WriteLine($"Случайно сгенерированная матрица размером {n}x{m} :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                   mat[i,j] = rnd.Next(20) + 1;
                }
            }
            for ( i = 0; i < n; i++)
            {
                for ( j = 0; j < m; j++) 
                {
                    Console.Write(" " + mat [i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            
            int cnt = 0;
            for ( j = 0; j < n; ++j)
            {
                for ( i = 0; i < m - 1; ++i)
                    for (int k = i + 1; k < m; ++k)
                        if (mat[i,j] == mat[k, j]) 
                            goto SKIP_LABEL;
                ++cnt;
            SKIP_LABEL:;
            }

            int cnc = 0;
            for (i = 0; i < m; ++i)
            {
                for (j = 0; j < n - 1; ++j)
                    for (int k = j + 1; k < n; ++k)
                        if (mat[i, j] == mat[i, k])
                            goto SKIP_LABE;
                ++cnc;
            SKIP_LABE:;
            }

            Console.WriteLine("Количество строк, все элементы которых различны = " + cnc);
            Console.WriteLine("Количество столбцов, все элементы которых различны = " + cnt);
            Console.ReadKey();
        }
    }
}


