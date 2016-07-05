using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forAndForeachLoops
{
    class Program
    {
        static void Main(string[] args)

        {
            
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            string dinner;

            //tell each dwarf that his dinner is ready, using a for loop
            for (int i = 0; i < sevenDwarves.Length; i++)

            {
                Console.WriteLine("What do you want for dinner, " + sevenDwarves[i] + "?");
                dinner = Console.ReadLine();
                Console.WriteLine("Here is your " + dinner + ", " + sevenDwarves[i] + ".");
            }
            //tell each dwarf that his dinner is ready, using a foreach loop
            foreach (string dwarf in sevenDwarves)
            {
                Console.WriteLine("And here is a nice warm drink, " + dwarf + ".");
            }
        }
    }
}
