using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    //Constants are immutable values which are known
    //at compile time and do not chnage for the life of the program.


    class Program
    {
        //constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string birthday = "08/19/1993";
        
        static void Main(string[] args)
        {
            Console.WriteLine("my birthday is always going to be: {0}", birthday);
            Console.Read();
        }
    }
}
