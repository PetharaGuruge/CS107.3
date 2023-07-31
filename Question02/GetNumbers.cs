using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    public class GetNumbers
    {
        protected int num1;
        protected int num2;

        public GetNumbers()
        {
            Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            num2 = int.Parse(Console.ReadLine());
        }
    }
}
