using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Summation sum = new Summation();
                Console.WriteLine($"Sum: {sum.Add()}");

                Subtraction sub = new Subtraction();
                Console.WriteLine($"Difference: {sub.Subtract()}");

                Multiplication mul = new Multiplication();
                Console.WriteLine($"Product: {mul.Multiply()}");

                Division div = new Division();
                Console.WriteLine($"Quotient: {div.Divide()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
