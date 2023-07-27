using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr = new int[10];

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter an integer: ");
                arr[i] = int.Parse(Console.ReadLine());

                ArrayWork objVal = new ArrayWork();

            }
        }
    }
}
