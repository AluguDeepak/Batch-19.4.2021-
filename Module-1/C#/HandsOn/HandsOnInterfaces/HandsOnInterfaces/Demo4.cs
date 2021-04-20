using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    //Generic Interfaces
   public interface ISample<T>
    {
        T M();
        void M1(T a);
    }

    class Demo4 : ISample<int>
    {
        public int M()
        {
            throw new NotImplementedException();
        }

        public void M1(int a)
        {
            throw new NotImplementedException();
        }
    }
    class Demo5 : ISample<string>
    {
        public string M()
        {
            throw new NotImplementedException();
        }

        public void M1(string a)
        {
            throw new NotImplementedException();
        }
    }
}
