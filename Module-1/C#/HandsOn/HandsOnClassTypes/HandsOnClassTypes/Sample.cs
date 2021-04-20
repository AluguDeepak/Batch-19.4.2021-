using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    //Generic Class
    class Sample<T>
    {
        public T a;
        public T b;
        public void Accept(T l,T m)
        {

        }
        public T Get(T k)
        {
            return k;
        }
    }
    class Test<K>:Sample<K>
    {

    }
    class Derived:Sample<int>
    {

    }
    class Test_Sample
    {
        static void Main()
        {
            Sample<int> s1 = new Sample<int>();
            s1.a = 10;
            s1.b = 20;
            int c = s1.a;
            int k=s1.Get(200);
            Sample<char> s2 = new Sample<char>();
            s2.a = 'b';
            s2.b = '4';
            char ch = s2.Get('k');
            Sample<string> s3 = new Sample<string>();
            s3.Accept("Ram", "Krishna");
            Derived derived = new Derived();
            derived.a = 10;
            Test<int> t = new Test<int>();
            t.a = 10;
            Test<String> t1 = new Test<string>();
            t1.a = "ABC";
        }
    }
}
