using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The sum is:");
            Console.WriteLine(Add(num1, num2));
            Console.Read();

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
