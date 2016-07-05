using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
                Console.Write("Who will win? choose between: neymar, suarez, messi, ronaldo");
               string input = Console.ReadLine();



                  switch (input)
                {
                    case "neymar":
                    case "messi":
                        Console.WriteLine("Good choice he probably wins as he is one of the best player in the world!");

                        break;

                    case "ronaldo":

                

                      Console.WriteLine("No good enough");

                        break;
                case "suarez":

                       Console.Write("He is one of the best striker in the world");

                        break;

                    default:
                        Console.WriteLine("I'm sorry, I don't understand that!");

                        break;
                }
             
    
            
            Console.ReadLine();
        }
    }
}
