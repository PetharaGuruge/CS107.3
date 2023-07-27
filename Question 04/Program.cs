using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class objSay = new Class();
            objSay.sayHello();

            //a public method can be accessed and called by any other classes 
            //but a private method can only be called the class that it is contained in 
        }
    }
}
