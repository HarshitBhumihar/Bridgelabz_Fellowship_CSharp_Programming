using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    internal class PrivateConstructor
    {
        private PrivateConstructor()
        {
            Console.WriteLine("Private Constructor");
        }
        public static void show()
        {
            PrivateConstructor d = new PrivateConstructor();
        }
    }
}
