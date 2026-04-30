using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class MultilevelInheitance
    {
        internal class GP
        {
            public void grandparent()
            {
                Console.WriteLine("This is Grand Parent Class");
            }
        }
        internal class P : GP
        {
            public void parent()
            {
                Console.WriteLine("This is Parent Class");
            }
        }
        internal class C : P
        {
            public void child()
            {
                Console.WriteLine("This is Child Class");
            }
        }
    }
}
