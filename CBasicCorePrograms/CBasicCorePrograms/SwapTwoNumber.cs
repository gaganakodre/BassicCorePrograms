using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasicCorePrograms
{
    internal class SwapTwoNumber
    {
        public void Quotient()
        {
            Console.WriteLine("Enter the  first number ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  second number ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap Num1= " + Num1 + " Num2= " + Num2);
            Num1 = Num1 + Num2;
            Num2 = Num1 - Num2;
            Num1 = Num1 - Num2;
            Console.Write("After swap Num1= " + Num1 + " Num2= " + Num2);

        }
    }
}
