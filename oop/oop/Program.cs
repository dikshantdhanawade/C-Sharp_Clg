using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class car
    {
        string color = "red";
        static void Main(string[] args)
        {
            //class

            car myObj=new car();
            Console.WriteLine(myObj.color);

            //multiple objects

            car myObj1 = new car();
            car myObj2 = new car();
            Console.WriteLine(myObj1.color);    
            Console.WriteLine(myObj2.color);

        }
    }
}
