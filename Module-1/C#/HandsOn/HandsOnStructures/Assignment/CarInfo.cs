using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class CarInfo
    {
        Car[] catelog = new Car[10];
        public void AddNewCar(Car car)
        {
            //Add new Car details to catelog
        }
        public Car GetCar(string make,string model)
        {
            //Search a car from the catelog using make and model and return.
        }
        public void Modify(string make, string model,double price)
        {
            //Search a car from the catelog using make and model
            //modify the price of the searhed car
            //add to catelog
        }
        public void ListCars()
        {
            //dispaly all cars details using foreach
        }
        public void DeleteCar()
        {
            //write functionality to deleting a car.
        }

    }
}
