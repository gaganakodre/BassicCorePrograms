namespace CBasicCorePrograms
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the realtive number to perform some operation");
            Console.WriteLine("Press 1 to perform the filp coin and percentage of Head and Tail");
            Console.WriteLine("press 2 to perform leap year fuction");
            int problem = Convert.ToInt32(Console.ReadLine());
            switch (problem)
            {
                case 1:
                    FlipCoin1 flipCoin = new FlipCoin1();//FlipCoin1
                    flipCoin.Flip_Percentage();
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.Leap_Year();
                    break;
            }
        }
    }
}
