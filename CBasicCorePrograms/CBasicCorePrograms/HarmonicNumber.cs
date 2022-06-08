using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasicCorePrograms
{
    internal class HarmonicNumber
    {
        public void Hormonics()
        {
            float Result_Harmonic = 0;
            Console.WriteLine("Enter the value of N for the Nth HOrmoni:");
            int N = Convert.ToInt32(Console.ReadLine());
            for (float i = 1; i <= N; i++)
            {
                Result_Harmonic += 1 / i;
            }
            Console.WriteLine("The Nth Harmonic is given by {0}", Result_Harmonic);
        }
    }
}
