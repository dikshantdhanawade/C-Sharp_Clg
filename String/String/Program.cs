using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Length
            string name = "Dikshant";
            Console.WriteLine("the length is " + name.Length);

            //upeercase  , lowercase

            string txt = "Haris";
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(txt.ToUpper());

        }
    }
}
