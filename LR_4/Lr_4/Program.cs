using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введитe размер массива - ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int d;
            int i;
            int q, j;
            for(i=0; i<n; i++)
            {
                Console.Write($"Введитe элемент массива A[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
                
            }
            d = a[1] - a[0];

            i = 1;
            while (i<n && a[i] - a[i - 1] == d)
            {
                i++;
            }
           
            if (i == n )
            {
                Console.WriteLine($"Этот массив - арифметическая прогрессия с разницей d = {d}");
            }
            else { Console.Write("Это не арифметическая прогрессия:"); 
                Console.WriteLine("0"); }

            q = a[1] / a[0];
            j = 1;
            while (j < n && a[j] / a[j - 1] == q)
            {
                j++;
            }
            if (j == n)
            {
                Console.WriteLine($"Этот массив - геометрическая прогрессия со знаменателем q = {q}");
            }
            else
            {
                Console.Write("Это не геометрическая прогрессия:");
                Console.WriteLine("0");
            }
            Console.ReadKey();
        }
    }
}
