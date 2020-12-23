using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ColorPhone:BlackWhitePhone
    {
        public bool wifi = true;
        public override void Call()
        {
            Console.WriteLine("From ColorPhone");
        }
        public override void RingTone()
        {
            Console.WriteLine("*Song*");
        }
        public virtual void SurfTheNet()
        {
            Console.WriteLine("Internet");
        }
    }
}
