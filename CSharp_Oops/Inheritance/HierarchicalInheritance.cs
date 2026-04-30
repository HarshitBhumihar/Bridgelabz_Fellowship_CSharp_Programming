using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class HierarchicalInheritance
    {
        internal class Parent
        {
            public void show()
            {
                Console.WriteLine("This is Parent Class");
            }
        }
        internal class Child1 : Parent
        {
            public void s1()
            {
                Console.WriteLine("This is Child1 Class");
            }
        }
        internal class Child2 : Parent
        {
            public void s2()
            {
                Console.WriteLine("This is Child2 Class");
            }
        }
    }
}
