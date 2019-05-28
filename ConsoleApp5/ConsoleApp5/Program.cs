using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {

            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                //throw;
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, number too long or too short");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }




            


            


            Console.ReadKey();
            
        }
    }
}
