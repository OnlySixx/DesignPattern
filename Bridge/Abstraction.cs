using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.BridgePattern
{
    class Abstraction
    {
        protected Implementor implementor;
        public Implementor Implementor
        {
            set { implementor = value; }
        }
        virtual public void Operation()
        {
            implementor.Operation();
        }

    }
}
