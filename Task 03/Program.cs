using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter KM Value: ");
            int km = int.Parse(Console.ReadLine());

            ConvertValues objVal = new ConvertValues();

            int result = objVal.KilometerTOMeter(km);

            Console.WriteLine("Meter Value is " + result);

            Console.ReadKey();
        }
    }
}
