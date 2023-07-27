using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_06
{
    class CreateArray
    {
        public CreateArray(int size) {
            int i;
            int []arr = new int[size];

            for (i = 0; i < size; i=i+2)
            {
                Console.WriteLine("Enter an integer: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write($"Array = [ ");
            for (i = 0; i < size; i++)
            {
                Console.Write($" {arr[i]},");
            }
            Console.Write($"]");
        }
    }
}
