using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    internal class Parameterized
    {
        {
        int id;
        String name;
        public Parameterized(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name);
        }
    }
}
