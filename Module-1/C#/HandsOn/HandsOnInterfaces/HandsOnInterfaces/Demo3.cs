using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    interface IX
    {
        void M();
        void M1();
    }
    interface IY
    {
        void M();
        void M2();
    }
    class Demo3 : IX, IY
    {
        public void M1() { }
        public void M2() { }
        //explicit implementation
        void IX.M(){}
        void IY.M() { }
        static void Main()
        {
            IX obj = new Demo3();
            obj.M();
            obj.M1();
            IY obj1 = new Demo3();
            obj1.M();
            obj1.M2();
        }

    }
}
