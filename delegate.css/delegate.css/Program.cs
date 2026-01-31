using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate.css
{
    internal class Program
    {
        public void fun1 ()

        {
            Console.WriteLine("fun1");
        }
        public delegate void myDelegate();
        static void Main(string[] args)
        {

            Program obj = new Program();
            myDelegate del=new myDelegate(obj.fun1);
            del+=obj.fun1;
            del();

        }
    }

}
