using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question_07
{
    class VectorScalar
    {
        public VectorScalar(int s1, int s2) { 
            int i, j;
            int[] arr1 = new int[s1];
            int[] arr2 = new int[s2];

            for (i = 0; i < s1; i++)
            {
                Console.Write($"Enter an element at position ({i}): ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (j = 0; j < s2; j++)
            {
                Console.Write($"Enter an element at position ({j}): ");
                arr2[j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private void ScalarSum(int arr1, int arr2, int s1, int s2)
        {
            int ss1 = 0, ss2 = 0;

            for (int i = 0; i < s1; i++)
            {
                ss1 = ss1 + arr1[i];
            }


        }
    }
}
