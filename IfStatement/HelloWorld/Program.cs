using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = 54;
            int userGuess = 0;
            
            while (userGuess != numberToGuess)
            {
                Console.Write("Enter your guess: ");
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess > numberToGuess)
                {
                    Console.Write("{0} is too high!", userGuess);
                }
                else if (userGuess < numberToGuess)
                {
                    Console.Write("{0} is too low!", userGuess);
                }
                else Console.Write("{0} is right! Congratulations.", userGuess);
                
            }
            Console.ReadLine();
        }
    }
}
