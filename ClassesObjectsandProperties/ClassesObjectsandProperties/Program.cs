using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsandProperties
{

    class car
    {
        public string make;
        public string model;
        public int price;

        private int mileage;

        public static int numberOfCars;

        public int Mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                if (value > 0)

                mileage = value;
            }
        }

    } //end of car class 
    class Program


    {
        static void Main(string[] args)
        {
            //declaring the number of cars 
            car.numberOfCars = 0;
            
             

            car car1 = new car();
            car1.make = "Mercedes";
            car1.model = "SerieA";
            car1.price = 3000;
            car1.Mileage = 87000;
            car.numberOfCars++;

            car car2 = new car();
            car2.make = "BMW";
            car2.model = "X7";
            car2.price = 2055;
            car2.Mileage = 100000;
            car.numberOfCars++;

            car car3 = new car();
            car3.make = "AUDI";
            car3.model = "A3";
            car3.price = 2000;
            car3.Mileage = 75000;
            car.numberOfCars++;

            //displaying the number of cars in stoke
            Console.WriteLine("The number of cars in stoke is: {0}", car.numberOfCars);
            Console.WriteLine();

            //displaying car details 
            Console.WriteLine("The details of this car are: ");
            Console.WriteLine("Make and model: {0} {1}, price: £{2:N0}, mileage: {3}.", car1.make, car1.model, car1.price, car1.Mileage);
            Console.WriteLine("The details of this car are: ");
            Console.WriteLine("Make and model: {0} {1}, price: £{2:N0}, mileage: {3}.", car2.make, car2.model, car2.price, car2.Mileage);
            Console.WriteLine("The details of this car are: ");
            Console.WriteLine("Make and model: {0} {1}, price: £{2:N0}, mileage: {3}.", car3.make, car3.model, car3.price, car3.Mileage);
            Console.WriteLine();
            Console.ReadLine();

        }//end main
    }
}
