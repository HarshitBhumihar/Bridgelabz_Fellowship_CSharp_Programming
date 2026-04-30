using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphishm
{
    internal class CompileTime
    {
        public void add(int a, int b)
        {
            Console.WriteLine("sum of two number is :" + (a + b));
        }
        public void add(int a, int b, int c)
        {
            Console.WriteLine("sum of three number is" + (a + b + c));
        }
    }
}
