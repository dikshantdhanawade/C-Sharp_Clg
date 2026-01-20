using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fctorial_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            int number = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"The factorial of {number} is {factorial}");
            Console.ReadLine();
        }
    }
}
