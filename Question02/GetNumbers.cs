using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    class GetNumbers
    {
        public int num1, num2;

        public void cal()
        {

            Console.WriteLine("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            num2 = int.Parse(Console.ReadLine());
        }
    }
}
