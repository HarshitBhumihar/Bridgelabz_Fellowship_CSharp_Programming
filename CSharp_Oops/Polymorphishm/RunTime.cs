using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphishm
{
    internal class RunTime
    {
        internal class Animal
        {
            public virtual void sound()
            {
                Console.WriteLine("sound of the animal");
            }
        }
        internal class Animal2 : Animal
        {
            public override void sound()
            {
                Console.WriteLine("sound of the animal2");

            }

        }
    }
}
