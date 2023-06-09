using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle: ");
            double r = double.Parse(Console.ReadLine());

            FindValues objVal = new FindValues();

            double a = objVal.findArea(r);
            double c = objVal.findCircumference(r);

            Console.WriteLine("Area: " + a);
            Console.WriteLine("Circumference: " + c);

            Console.ReadKey();
        }
    }
}
