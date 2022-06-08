using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasicCorePrograms
{
    internal class FlipCoin1
    {
        public void Flip_Percentage()
        {
            int Head = 0;
            int Tail = 0;

            Console.WriteLine("Enter the number of time you want to flip the coin");
            int Number_of_Flips = Convert.ToInt32(Console.ReadLine());
            while (Number_of_Flips <= 0)

            {
                Console.WriteLine("Invalid please enter the correct number times you want to filp");
                Console.WriteLine("please enter the number again");
                Number_of_Flips = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < Number_of_Flips; i++)
            {
                Random flip = new Random();
                int HoT = flip.Next(0, 2);
                if (HoT < 0.5)
                {
                    Head++;
                }
                else
                {
                    Tail++;
                }
                float Head_percentage = (float)Head * 100 / Number_of_Flips;
                float Tail_percentage = (float)Tail * 100 / Number_of_Flips;

                Console.WriteLine("The percentage of number of times heads" + Head_percentage);
                Console.WriteLine("The percentage of number of times Tails" + Tail_percentage);
            }

        }
    }
}
