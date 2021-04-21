using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnEnums
{
    class Program
    {
        enum Engine { Start,Stop};
        //Enum is used to assign constant name to group of numeric integer value.
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thusday,
            Friday=100,
            Saturday,
            Sunday
        };
        public enum Categories:byte
        {
            Electronics=2,Food=5,Fashion=9,Automotive=10
        };
        public Categories Categorie
        {
            get;
            set;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Friday); //Friday
            int day = (int)WeekDays.Saturday;
            Console.WriteLine((int)WeekDays.Friday);
            Categories categories = Categories.Automotive;
            Console.WriteLine(categories);
            int value = (byte)Categories.Food;
            Console.WriteLine(value);
            Program obj = new Program();
            obj.Categorie = Categories.Automotive;
            Console.WriteLine(obj.Categorie);
            Console.WriteLine((byte)obj.Categorie);
            Engine Start = Engine.Start;
            Console.WriteLine(Start);
            Console.WriteLine((int)Start);
        }
    }
}
