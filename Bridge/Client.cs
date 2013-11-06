using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.BridgePattern
{
    class Client
    {
        public static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction();
            // Set implementation and call
            abstraction.Implementor = new ConcreteImplementorA();
            abstraction.Operation();
            // Change implemention and call
            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();
        }
    }
}
