using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                GetNumbers getNumbers = new GetNumbers();
                getNumbers.SetNumbers(num1, num2);

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
