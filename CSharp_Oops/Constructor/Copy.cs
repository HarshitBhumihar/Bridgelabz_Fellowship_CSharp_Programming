using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    internal class Copy
    {
        int id;
        string name;
        int age;
        public Copy(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public Copy(Copy c)
        {
            this.id = c.id;
            this.name = c.name;
            this.age = c.age;

        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + age);
        }
    }
}
