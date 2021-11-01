using System;
using System.Collections.Generic;
using System.Text;

namespace pratik1
{
    class Phone : Product
    {
        public Phone(int id, string name, string brand, int quantity, double price,string system,int ram):base(id,name,brand,quantity,price)
        {
            this.System=system;
            this.Ram = ram;
        }
           public string System;
           public int Ram;
        public override string ToString()
        {
            return base.ToString() + $" System: {this.System}, Ram: {this.Ram}";
        }
    }
}
