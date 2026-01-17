using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_And_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter an Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) { 
                Console.WriteLine("{0} is Even Number", num);
            }
            else
            {
                Console.WriteLine("{0} is Odd Number", num);
            }
        }
    }
}
