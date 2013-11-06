using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.Prototype
{
    public abstract class Key
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string owner;

        public string Owner
        {
            get {return owner;}
            set {owner = value;}
        }

        public Key(string name, string owner)
        {
            this.name = name;
            this.owner = owner;
        }
        public abstract Key Clone();
        public override string ToString()
        {
            return this.Name+", belongs to "+ this.Owner;
        }
    }
    public class GateKey:Key
    {
        public GateKey(string owner):base("Gate Key",owner){}
        public override Key Clone()
        {
            return new GateKey(this.Owner);
        }

    }
    public class CabinetKey : Key
    {
        public CabinetKey(string owner) : base("Cabinet Key", owner) {}
        public override Key Clone()
        {
            return new GateKey(this.Owner);
        }
    }
    public class Client
    {
        public static void Main(string[] args)
        {
            Key oldGateKey,newGateKey,oldCabinetKey,newCabinetKey;
            oldGateKey = new GateKey("GF");
            newGateKey = oldGateKey.Clone();
            newGateKey.Owner = "Me";

            oldCabinetKey = new CabinetKey("Me");
            newCabinetKey = oldCabinetKey.Clone();
            newCabinetKey.Owner = "GF";

            Console.WriteLine(oldGateKey);
            Console.WriteLine(newGateKey);
            Console.WriteLine(oldCabinetKey);
            Console.WriteLine(newCabinetKey);
        }
    }
    
}
