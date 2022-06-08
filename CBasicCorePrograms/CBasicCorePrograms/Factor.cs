using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasicCorePrograms
{
    internal class Factor1
    { 


         public void factor()
    {
        Console.WriteLine("Enter the number: ");
        int Number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("prime Factors for {0} are,", Number);
        for (int i = 2; i < Number; i++)
        {
            if (Number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
}
