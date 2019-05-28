using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
       
        

        static void Main(string[] args)
        {
            string friend1 = "Frank";
            string friend2 = "Trevor";
            string friend3 = "Dill";
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.Read();
       
        }

        public static void GreetFriend(string string1)
        {
            Console.WriteLine("Hi " + string1 + ", my friend!");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }


    }
}
