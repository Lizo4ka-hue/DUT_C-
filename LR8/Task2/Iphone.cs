using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Iphone:ColorPhone
    {
        public override void Call()
        {
            Console.WriteLine("From IPhoneD");
        }
        public override void RingTone()
        {
            Console.WriteLine("*Song*");
        }
        public override void SurfTheNet()
        {
            Console.WriteLine("Internet");
        }
    }
}
