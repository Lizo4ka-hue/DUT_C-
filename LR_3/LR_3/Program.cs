using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите четырехзначное число = ");
            int i = Convert.ToInt32(Console.ReadLine());
            int k, _i ;
            bool result;
            if(i < 999 || i >= 9999)
            {
                while(i<999 || i>=9999)
                {   
                 Console.WriteLine("Вы ввели не четырехзначное число!");
                 Console.Write("Введите четырехзначное число = ");
                 i = Convert.ToInt32(Console.ReadLine());
                }
            }
            _i = i;
            k = (_i % 10) * 1000;
            _i = _i / 10;
            k = k + (_i % 10) * 100;
            _i = _i / 10;
            k = k + (_i % 10) * 10;
            _i = _i / 10;
            k = k + (_i % 10);

            /*(i == k) ? result = true : result = false;*/
            if (i == k) { result = true;
                Console.WriteLine($"Число читается одинаково слево направо и справа на лево: result = {result}");}
            else { result = false;
                Console.WriteLine($"Число читается по разному слево направо и справа на лево: result = {result}");}
            Console.ReadKey();
        }
    }
}
