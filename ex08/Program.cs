namespace ex08
{
    internal class Program
    {
        public static bool ValidTime(int h, int m, int s)
        {
            bool validTime;

            if (h < 0 || h > 23 || m < 0 || m > 59 || s < 0 || s > 59)
                validTime = false;
            else
                validTime = true;

            return validTime;
        }
        static void Main(string[] args)
        {
            //Variable Declaration
            int time, hours, minutes, seconds;
            bool validity;

            //Initial Values
            Console.Write("Write a time in format hhmmss: ");
            time = Convert.ToInt32(Console.ReadLine());

            //Algorhythms and Calculus
            hours = time / 10000;
            minutes = time / 100 % 100;
            seconds = time % 100;
            validity = ValidTime(hours, minutes, seconds);

            //Output Values
            if (validity)
                Console.WriteLine($"The time {hours:00}:{minutes:00}:{seconds:00} is a valid time");
            else
                Console.WriteLine($"The time {hours:00}:{minutes:00}:{seconds:00} is not a valid time");
        }
    }
}
