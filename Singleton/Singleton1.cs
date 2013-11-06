using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.Singleton
{
    
    class Singleton1
    {
        static Singleton1 instance = null;
        Singleton1()
        {

        }
        public static Singleton1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton1();
                }
                return instance;
            }
        }

    }
}
