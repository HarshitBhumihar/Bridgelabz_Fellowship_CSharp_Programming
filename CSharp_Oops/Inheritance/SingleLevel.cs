using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class SingleLevel
    {
        internal class Parent
        {
            public void parent()
            {
                Console.WriteLine("This is Parent Class");

            }
        }
        internal class Child : Parent
        {
            public void child()
            {
                Console.WriteLine("This is Child Class");
            }
        }
    }
}
