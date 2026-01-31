using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit Casting
            int myInt = 9;
            double mydouble= myInt; // Automatic casting: int to double
            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(mydouble);   // Outputs 9

            //Explicit Casting

            double myDouble = 8.80;
            int myInt2 = (int)myDouble;

            Console.WriteLine(myDouble);   // Outputs 8.8
            Console.WriteLine(myInt2);     // Outputs 8


        }
    }
}
