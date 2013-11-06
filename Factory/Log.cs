using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.Factory
{
    public abstract class Log
    {
        public abstract void Write();
    }
    public class EventLog : Log
    {
        public override void Write()
        {
            Console.WriteLine("EventLog Write Success!");
        }
    }
    public class FileLog : Log
    {
        public override void Write()
        {
            Console.WriteLine("FileLog Write Success!");
        }
    }
}
