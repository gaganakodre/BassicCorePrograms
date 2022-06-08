namespace CBasicCorePrograms
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the realtive number to perform some operation");
            Console.WriteLine("Press 1 to perform the filp coin and percentage of Head and Tail");
            Console.WriteLine("Press 2 to perform leap year");
            Console.WriteLine("Press 3 to perform power of 2");
            Console.WriteLine("Press 4 to perform Hormonic Fuction");
            Console.WriteLine("press 5 to perform Factors");
            Console.WriteLine("Press 6 to perform the Quotient remainder");
            Console.WriteLine("press 7 to perform swap number");
            Console.WriteLine("Press 8 to perform vevn or odd");
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
                case 3:
                    PowerOfTwo power = new PowerOfTwo();
                    power.Power_Of_Two();
                    break;
                case 4:
                    HarmonicNumber harmonic = new HarmonicNumber();
                    harmonic.Hormonics();
                    break;
                case 5:
                    Factor1 factor = new Factor1();
                    factor.factor();
                    break;
                case 6:
                    QutionentAndRemainder quotient = new QutionentAndRemainder();
                    quotient.Quotient();
                    break;
                case 7:
                    SwapTwoNumber swapnum = new SwapTwoNumber();
                    swapnum.Quotient();
                    break;
                case 8:
                    EvenOrOdd even = new EvenOrOdd();
                    even.EvenorOdd();
                    break;
            }
        }
    }
}
