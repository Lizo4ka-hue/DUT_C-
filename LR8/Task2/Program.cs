using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Phone");
            Phone dp = new Phone();
            dp.Call();
            Console.WriteLine();

            Console.WriteLine("Button Phone");
            ButtonPhone bp = new ButtonPhone();
            bp.RingTone();
            Console.WriteLine();

            Console.WriteLine("BlackWhite Phone");
            BlackWhitePhone nokia = new BlackWhitePhone();
            nokia.Call();
            nokia.RingTone();
            Console.WriteLine();

            Console.WriteLine("Color Phone");
            ColorPhone samsung = new ColorPhone();
            samsung.Call();
            samsung.SurfTheNet();
            Console.WriteLine();

            Console.WriteLine("iPhone");
            Iphone EightPlus = new Iphone();
            EightPlus.Call();
            EightPlus.SurfTheNet();
            Console.WriteLine();

            

        }
    }
}
