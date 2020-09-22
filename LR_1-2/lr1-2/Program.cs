using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr1_2
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("Лабораторная работа 1, вариант 11");
            Console.WriteLine("");
             int sec, min, hour;
            Console.Write("Введите число в секундах: ");
            int sec1 = Convert.ToInt32(Console.ReadLine());
            hour = sec1 / 3600;
            min = (sec1 - hour * 3600) / 60;
            sec = sec1 - hour * 3600 - min * 60;
            Console.WriteLine($"Ответ: {sec1} секунд - это {hour} часов, {min} минут, {sec} секунд");
            Console.WriteLine("");
            Console.WriteLine("Нажмите любую клавишу, чтобы перейти ко 2-ой лабораторной работе..");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Лабораторная работа 2, вариант 11");
            Console.WriteLine("");
            int nn, nk;
            double ak;
            Console.Write("Введите nn = ");
            nn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите nk = ");
            nk = Convert.ToInt32(Console.ReadLine());
            for (int i = nn; i < nk; i++)
            {
                ak = (Math.Pow(-1, i * i - 2 * i + 3) * i + 1) / (i * i - 2);
                Console.Write("Ответ: "); Console.WriteLine(Math.Round(ak,2));
            }
            
            Console.WriteLine("");
            Console.WriteLine("Нажмите любую клавишу, чтобы выйти..");
            Console.ReadKey();
        }
    }
}
