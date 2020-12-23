using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ButtonPhone:Phone
    {
        public bool Buttons = true;

        public override void Call()
        {
            Console.WriteLine("Call from button");
        }
    }
}
