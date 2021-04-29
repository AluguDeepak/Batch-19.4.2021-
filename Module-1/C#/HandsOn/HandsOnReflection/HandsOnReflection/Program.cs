using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;
namespace HandsOnReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get Metadata(Methods,Properties,Consturctors etc) of Arraylist using Reflection
            ArrayList arrayList = new ArrayList();
            Type type = arrayList.GetType();
            Console.WriteLine(type.IsClass?"Array is a Class":"Not a Class");
            //display all the methods
           MethodInfo []methods =type.GetMethods();
            //foreach(var m in methods)
            //{
            //    Console.WriteLine(m.Name);
            //}
            //display constructors
            //ConstructorInfo []constructors=type.GetConstructors();
            //foreach(var c in constructors)
            //{
            //    Console.WriteLine(c);
            //}
            //display properties
            PropertyInfo []properties=type.GetProperties();
            foreach (var p in properties)
                Console.WriteLine(p.Name +" "+ p.PropertyType);
        }
    }
}
