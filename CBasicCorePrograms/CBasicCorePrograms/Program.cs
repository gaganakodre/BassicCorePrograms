namespace CBasicCorePrograms
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the realtive number to perform some operation");
            Console.WriteLine("Press 1 to perform the filp coin and percentage of Head and Tail");
            int problem = Convert.ToInt32(Console.ReadLine());
            switch (problem)
            {
                case 1:
                    FlipCoin1 flipCoin = new FlipCoin1();//FlipCoin1
                    flipCoin.Flip_Percentage();
                    break;
            }
        }
    }
