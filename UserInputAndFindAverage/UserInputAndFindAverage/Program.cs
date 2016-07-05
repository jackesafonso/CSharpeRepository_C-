using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputAndFindAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int yourNumber; //declaring yourNumber
            int counter = 0; // declaring counter
            int[] numberList = new int[5]; //declaring an array
            decimal total = 0m; //declaring that total will be in decimal values
            decimal average = 0m; // declaring that average will be in decimal values

            do
            {
                Console.Write("Please enter a number: "); //user input control loop 
                yourNumber = Convert.ToInt16(Console.ReadLine()); //we have to convert into numbers because everything that comes from Console.ReadLine comes in form of a string
                numberList[counter] = yourNumber; // count the number of elements on the array
                counter++; 
            }
            while (counter < 5);

            for (int i = 0; i < numberList.Length; i++)
            {
                total += numberList[i]; // sum the element on the array
            }

            average = total / numberList.Length; // calculate the average of elements on the array
            Console.WriteLine("the total is: " + total);
            Console.WriteLine("The average is: " + average);
            Console.ReadLine(); 
        }
    }
}
