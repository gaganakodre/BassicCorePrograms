using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasicCorePrograms
{
    internal class LeapYear
    {
        public void Leap_Year()
        {
            Console.WriteLine("enter the year");
            int Year = Convert.ToInt32(Console.ReadLine());
            while (Year < 1000 || Year > 9999)
            {
                Console.WriteLine("please enter the valid four didgit year");
                Year = Convert.ToInt32(Console.ReadLine());
            }
            if (((Year % 4 == 0) && (Year % 100 == 0)) || (Year % 400 == 0))
            {
                Console.WriteLine(Year + "is a leap year");
            }
            else
            {
                Console.WriteLine(Year + "is a leap not a year");
            }




        }


    }
}
