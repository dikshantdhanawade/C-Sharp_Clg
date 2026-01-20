using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Sum_of_Array_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int arrLength = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[arrLength];   

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine("Enter element {0}:", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < arrLength; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("Sum of array elements: " + sum);
        }
    }
}
