using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.BridgePattern
{
    class RefinedAbstraction:Abstraction
    {
        // Methods
        override public void Operation()
        {
            implementor.Operation();
        }
    }
}
