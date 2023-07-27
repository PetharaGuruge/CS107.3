using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2; 
            Console.WriteLine("Enter the size of the array: ");
            s1 = int.Parse(Console.ReadLine());
            s2 = int.Parse(Console.ReadLine());

            VectorScalar objVal = new VectorScalar(s1, s2);
        }
    }
}
