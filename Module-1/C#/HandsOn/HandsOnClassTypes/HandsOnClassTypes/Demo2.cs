using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    class X
    {
        public virtual void F()
        {

        }
    }
    class Y : X
    {
        public sealed override void F()
        {
            base.F();
        }
    }
    class Z:Y
    {
        //public override void F() //Not override because Y.F() is sealed.
        //{
        //    base.F();
        //}
    }
    class Demo2
    {
    }
}
