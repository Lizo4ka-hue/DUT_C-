using System;

namespace LR10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { -3, 2, 5, 1 };
            int[] massiv = new int[mass.Length];
            Console.WriteLine("\nИсходный массив");



            for (int i = mass.Length - 1; i > -1; i--)
            {
                mass[i] = mass[i];
                massiv[i] = mass[i];



                Console.WriteLine(mass[i]);



            }
            Console.WriteLine("-----------");
            massiv.Change();
        }
    }
    public static class Complid
    {
        public static int[] Change(this int[] mass)
        {
            int max;
            max = mass[0];
            for (int i = 0; i < mass.Length; i++)
            {

                if (max < mass[i])
                {
                    max = mass[i];
                }


            }
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {

                    mass[i] = max;
                }
                Console.WriteLine(mass[i]);
            }
            return mass;
        }
    }
}
