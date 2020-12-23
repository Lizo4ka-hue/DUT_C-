using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class BlackWhitePhone:ButtonPhone
    {
        public bool display = true;
        public override void Call()
        {
            Console.WriteLine("From BlackWhitePhone");
        }

        public override void RingTone()
        {
            Console.WriteLine("*Song*");
        }
    }
}
