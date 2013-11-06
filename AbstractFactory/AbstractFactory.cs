using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Research.AbstractFactory
{
    class AbstractFactory
    {
        public static AbstractFactory GetInstance()
        {
            string factoryName = "FactoryName";
            AbstractFactory instance;
            if (factoryName != null)
            {
                instance = (AbstractFactory)Assembly.Load(factoryName).CreateInstance(factoryName);
            }
            else
            {
                instance = null;
            }
            return instance;
        }
        //public abstract Tax CreateTax();
    }
}
