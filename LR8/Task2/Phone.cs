using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Phone
    {
        public bool calls = true;
        public int numOfDigits = 10;

        public virtual void Call()
        {
            Console.WriteLine("Call");
        }

        public virtual void RingTone()
        {
            Console.WriteLine("Song");
        }
    }
}
