using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    internal class Practice
    {
        private int age;
        private string name;
        public void setdata(int a, string s)
        {
            age = a;
            name = s;
        }
        public int getage()
        {
            return age;

        }
        public string getname()
        {
            return name;
        }
    }
}
