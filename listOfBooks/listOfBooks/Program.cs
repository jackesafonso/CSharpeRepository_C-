using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listOfBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] listOfFruits = { "orange", "mango", "banana", "apple" };

            //here we are declaring the list myFruits, char response and string newFruit 
            List<string> myFruits = new List<string>() { "orange", "mango", "banana", "apple" };
            char response;
            string newFruit;

            do //  keeping running and asking the user to make choices 
            {

                Console.WriteLine("Here you have the list of fruits");
                Console.WriteLine("to add press a, to delete press d, to list press l, to sort press s, to exit press x");
                response = Convert.ToChar(Console.ReadLine().ToUpper());// Char response was used because we want to use onle a single case e.g. 'A' and ToUpper was used because we want to use capitals
 
                switch (response)
                {
                    
                    case 'A':
                        Console.WriteLine("Please enter the fruit you would like to add: ");
                        newFruit = Console.ReadLine();
                        myFruits.Add(newFruit); //this code was used to add fruits to the list newFruit
                        break;

                    case 'D':
                        Console.WriteLine("Please nter the fruit you would like to delete: ");
                        newFruit = Console.ReadLine();
                        myFruits.Remove(newFruit); //this code was used to remove fruits to the list newFruit
                        break;

                    case 'L':
                        for (int i = 0; i < myFruits.Count; i++) // this was used to provide the list (loop) myFruit on the screen
                        {
                            Console.WriteLine(myFruits[i]);
                        }
                        break;

                    case 'S':

                        

                        myFruits.Sort(); //this code was used to sort fruits on the list myFruit

                        break;
                    default:
                        break;


                }

              

            } while (response != 'X'); //users keep making choise as longer as user do not press X to exit 

                

              

            }

        }

        
    }

