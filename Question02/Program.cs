using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetNumbers myNums = new GetNumbers();
            myNums.cal();

            Summation mySum = new Summation(myNums.num1, myNums.num2);
            Substraction mySub = new Substraction();
            Multiplication myMul = new Multiplication();
            Division myDiv = new Division();

            mySum.cal();
            mySub.cal();
            myMul.cal();
            myDiv.cal();

            Console.ReadLine();
        }
    }
}
