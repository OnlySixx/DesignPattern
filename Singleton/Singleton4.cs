using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.Singleton
{
    class Singleton4
    {
        static readonly Singleton4 instance = new Singleton4();
       
        private Singleton4()
        {
        }
        public static Singleton4 Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
