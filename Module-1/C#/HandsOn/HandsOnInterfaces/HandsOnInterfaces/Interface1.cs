using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    interface Interface1
    {
        void M(); //method
        int Eid { get; set; } //perperty
    }
    class Demo:Interface1
    {
        int eid;
        public void M() { }
        public int Eid { get { return eid; } set { eid = value; } }

    }
}
