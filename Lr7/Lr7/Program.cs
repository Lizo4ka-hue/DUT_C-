using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Lr7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> chisla = new List<int>();
            int collChisel,chislo,count=0,searchChislo;
            Console.WriteLine("Введите сколько чисел будет - ");
            collChisel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число которое найти - ");
            searchChislo = Convert.ToInt32(Console.ReadLine());


            
            for (int i=0;i<collChisel;i++)
            {
                Console.WriteLine("Число -");
                chislo = Convert.ToInt32(Console.ReadLine());
                if (!chisla.Contains(chislo))
                {
                    chisla.Add(chislo);
                }
                

                else
                {
                    chisla.Add(chislo);
                    count++;
                }


            }
            Console.WriteLine("------------------------------");

            for(int i = 0;i<chisla.Count;i++)
            {
                if(chisla[i]==searchChislo)
                {
                    Console.WriteLine("Есть искаемое число");
                    break;

                }
                else
                {
                    Console.WriteLine("Нету искаемого числа");
                    break;
                }
            }
            
            Console.WriteLine("Количество повторяющихся чисел-" + count);
            Console.ReadKey();

        }
    }
}
