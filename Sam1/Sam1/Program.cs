using System;
using System.Linq;

namespace Sam1
{
    class Program
    {
        static void Main(string[] args)
        {
            Whisky whisky1 = new Whisky("Бренди", 2000, 39, "Италия", "Петропавл");
            Whisky whisky2 = new Whisky("Кетров", 2100, 49, "Италия", "Петропавл");
            whisky1.Add();
            whisky1.Display();
            whisky2.Add();
            
            whisky2.Display();
            Console.WriteLine("-------------");

            whisky1.Choose("Бренди");
            whisky2.Choose("Бренди");



        }
        
        
    }
}
