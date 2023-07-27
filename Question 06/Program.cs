using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;

            Console.WriteLine("Enter the size of the array: ");
            size = int.Parse(Console.ReadLine());

            CreateArray objVal = new CreateArray(size);
            Console.ReadKey();
        }
    }
}
