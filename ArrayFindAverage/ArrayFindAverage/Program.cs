using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFindAverage
{
    class Program
    {
        static void Main(string[] args)

        {

            /* int[] myNumber = { 1, 2, 3, 4, 5 };
             for (int i = 0; i < myNumber.Length; i++)
             {
               sum += myNumber[i];
             }


             Console.ReadLine();*/

           
            int sum = 0;
            int average = 0;

            int[] myNumber = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < myNumber.Length; i++)
            {
                sum += myNumber[i];
            }

            average = sum / myNumber.Length ; // sum divided by total elements in array

            Console.WriteLine("The Sum Of Array Elements Is : " + sum);
            Console.WriteLine("The Average Of Array Elements Is : " + average);
            Console.ReadLine();
        }
    }
}
