using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    public class Division : GetNumbers
    {
        public double Divide()
        {
            if (num2 != 0)
                return num1 / num2;
            else
                throw new DivideByZeroException("Cannot divide by zero!");
        }
    }
}
