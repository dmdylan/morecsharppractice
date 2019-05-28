using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature outside?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number, value set to 0");
            }


            if(numTemp < 10)
            {
                Console.WriteLine("Take the coat");
            }else if (numTemp == 10)
            {
                Console.WriteLine("It's 10 degrees C");
            }else
            {
                Console.WriteLine("Nice and cozy");
            }
        }
    }
}
