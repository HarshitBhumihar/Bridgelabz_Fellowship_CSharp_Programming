using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    internal class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("This is a Static Constructor");
        }
        public static void show()
        {
            Console.WriteLine("This is a Static Method");
        }

    }
}
