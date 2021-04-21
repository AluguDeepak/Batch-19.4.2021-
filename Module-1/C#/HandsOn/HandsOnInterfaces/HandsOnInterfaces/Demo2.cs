using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    interface IA
    {
        void M();
    }
    interface IB:IA
    {
        void M1();
    }
  class Class2:IB
    {
        public void M() { }
        public void M1() { }
    }
    class Demo2
    {
    }
}
