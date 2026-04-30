using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class MultipleInheritance
    {
        interface A
        {
            public void method1();


        }
        interface B
        {
            public void method2();

        }
        internal class C : A, B
        {
            public void method1()
            {
                Console.WriteLine("This is Method 1");
            }
            public void method2()
            {
                Console.WriteLine("This is Method 2");
            }
        }
    }
}
