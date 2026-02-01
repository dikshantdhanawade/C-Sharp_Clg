using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//private access modifier example
class car
{
    private string model = "mustang";
    
        static void Main(string[] args)
        {
        car Obj = new car();
        Console.WriteLine(Obj.model);
    }
    }

//public access modifier example

class bike
{
    public string model = "BMW";
}

class Program
{
    static void Main(string[] args)
    {
        bike myObj = new bike();
        Console.WriteLine(myObj.model);
    }
}

