using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Inherit
    {
        
            internal class Parent
            {
                public void car()
                {
                    Console.WriteLine("All Car Are Diesel");
                }
            }
            internal class Child : Parent
            {
                public void bike()
                {
                    Console.WriteLine("all Bike Are Petrol");
                }
            }
        }
}
