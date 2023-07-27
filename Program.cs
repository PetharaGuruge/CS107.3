using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, ch;

            Console.WriteLine("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            CalculateValues objVal = new CalculateValues();

            Console.WriteLine("Enter 1 for Addition \nEnter 2 for Substraction \nEnter 3 for Multiplication \nEnter 4 for Division \n");
            Console.WriteLine("Enter a chocie: ");
            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.WriteLine("Answer: " + objVal.Addition(num1, num2));
                    break;

                case 2:
                    Console.WriteLine("Answer: " + objVal.Substraction(num1, num2));
                    break;

                case 3:
                    Console.WriteLine("Answer: " + objVal.Multiplication(num1, num2));
                    break;

                case 4:
                    Console.WriteLine("Answer: " + objVal.Division(num1, num2));
                    break;
            }
            Console.ReadKey();
        }
    }
}
