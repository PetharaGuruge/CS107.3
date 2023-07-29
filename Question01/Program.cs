using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question01
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Dog myDog = new Dog();

            myAnimal.Pup();
            myDog.Pup();

            Console.ReadLine();
        }
    }
}
