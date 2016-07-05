using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticInstancePropertiesAndMethod
{

    class Program
    {



        class car
        {
            public string make;
            public string model;
            public int price;

            public Boolean sold;

            public static int numberOfCars;

            public void AddCar(string make, string model, int price)
            {
                this.make = make;
                this.model = model;
                this.price = price;
                this.sold = false;
                car.numberOfCars++;
            }
            //display the car for an individual car 
            public void ListCar()
            {
                Console.WriteLine("The details of this car are: {0}");
                Console.WriteLine("Make and model, {0} {1}, price: £{2:N0}.", make, model, price);//:N0 formats the number

                if (sold)
                {
                    Console.WriteLine("This car has been sold.");
                }
                else
                {
                    Console.WriteLine("This car has been unsold");
                }

                Console.WriteLine();

            }


            //record the sale of a car
            public void Sold(bool isSold, int price)
            {
                this.sold = isSold;
                this.price = price;

                //ajusting stoke level
                car.numberOfCars--;
            }



            static void Main(string[] args)
            {
                car.numberOfCars = 0;

                //add cars
                car car1 = new car();
                car1.AddCar("Mercedes", "SerieA", 3000);


                car car2 = new car();
                car2.AddCar("BMW", "X7", 2500);

                car car3 = new car();
                car3.AddCar("AUDI", "A3", 2000);

                //displaying cars details
                Console.WriteLine("Total number of cars in stoke is: {0}", car.numberOfCars);
                Console.WriteLine();

                car1.ListCar();
                car2.ListCar();
                car3.ListCar();

                //record the sale of a car
                car3.Sold(true, 350);

                //displaying cars details
                Console.WriteLine("Total number of cars in stoke is: {0}", car.numberOfCars);
                Console.WriteLine();


                car1.ListCar();
                car2.ListCar();
                car3.ListCar();

            }




        }


    }

}   
                         