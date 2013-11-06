using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.BridgePattern
{
    class ConcreteImplementorA:Implementor
    {
        // Methods
        override public void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}
