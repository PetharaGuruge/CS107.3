using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class ConvertValues
    {
        public void KilometerTOMeter()
        {
            Console.WriteLine("Enter KM Value: ");
            int km = int.Parse(Console.ReadLine());

            int m = km * 1000;

            Console.WriteLine("Meter Value is " + m);
        }
    }
}
