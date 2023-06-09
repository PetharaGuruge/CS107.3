using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter KM Value: ");
            int km = int.Parse(Console.ReadLine());

            ConvertValues objVal = new ConvertValues();
            objVal.KilometerTOMeter(km);

            Console.ReadKey();
        }
    }
}
