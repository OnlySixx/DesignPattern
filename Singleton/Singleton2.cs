using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.Singleton
{
    class Singleton2
    {
        static Singleton2 instance = null;
        static readonly object padlock = new object();
        Singleton2()
        {
            
        }
        public static Singleton2 Instance
        {
            
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton2();
                    }
                    return instance;
                }
            }
        }
       
    }
}
