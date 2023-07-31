using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Question04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the arrays: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr1 = new int[size];
            int[] arr2 = new int[size];

            Console.WriteLine("Enter elements for the 1st array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements for the 2nd array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int scalarSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarSum += arr1[i] + arr2[i];
            }
            Console.WriteLine("Scalar Sum: " + scalarSum);

            int[] vectorSum = new int[size];
            int[] vectorProduct = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorSum[i] = arr1[i] + arr2[i];
                vectorProduct[i] = arr1[i] * arr2[i];
            }

            int scalarProduct = 0;
            for (int i = 0; i < size; i++)
            {
                scalarProduct += vectorProduct[i];
            }
            Console.WriteLine("Scalar Product: " + scalarProduct);

            // Display Vector Sum and Vector Product
            Console.WriteLine("Vector Sum: [" + string.Join(", ", vectorSum) + "]");
            Console.WriteLine("Vector Product: [" + string.Join(", ", vectorProduct) + "]");
        }
    }
}
