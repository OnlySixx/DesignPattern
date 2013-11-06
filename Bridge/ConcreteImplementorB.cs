using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.BridgePattern
{
    class ConcreteImplementorB:Implementor
    {
        // Methods
        override public void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
            Console.ReadLine();
        }
    }
}
