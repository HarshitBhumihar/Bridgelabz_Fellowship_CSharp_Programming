using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class HybridInheritance
    {
        internal class Parent
        {
            public void method1()
            {
                Console.WriteLine("This is Method 1");
            }
        }
        internal class child : Parent
        {
            public void methyod2()
            {
                Console.WriteLine("This is Method 2");
            }
        }
        interface C
        {
            void method3();
        }
        internal class D : C
        {
            public void method3()
            {
                Console.WriteLine("This is Method 1 from Interface");
            }
        }
    }
}
