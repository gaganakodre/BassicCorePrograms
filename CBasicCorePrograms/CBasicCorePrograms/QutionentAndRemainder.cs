using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasicCorePrograms
{
    internal class QutionentAndRemainder
    {
        public void Quotient()
        {
            Console.WriteLine("Enter the  dividend to find the Quotient and Remainder ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor to find the Quotient and Remainder ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            if (dividend != 0 && divisor != 0)
            {
                int quotient = dividend / divisor;
                int remainder = dividend % divisor;

                Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
                Console.WriteLine("Quotient = " + quotient);
                Console.WriteLine("Remainder = " + remainder);
                Console.ReadLine();
            }
        }
    }
}
