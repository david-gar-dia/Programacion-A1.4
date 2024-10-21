namespace ex15
{
    internal class Program
    {
        public static string Increase1Second(int h, int m, int s)
        {
            int totalInSeconds, newH, newM, newS;
            string formattedNewTime;

            totalInSeconds = h * 3600;
            totalInSeconds += m * 60;
            totalInSeconds += s + 1;

            newH = totalInSeconds / 3600;
            newM = totalInSeconds % 3600 / 60;
            newS = totalInSeconds % 60;

            formattedNewTime = $"{newH:00}:{newM:00}:{newS:00}";

            return formattedNewTime;
        }
        static void Main(string[] args)
        {
            //Variabe Declaration
            string newTime;
            int hours, minutes, seconds;

            //Initial Values
            Console.Write("Type the number of hours: ");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the number of minutes: ");
            minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the number of seconds: ");
            seconds = Convert.ToInt32(Console.ReadLine());

            //Algorithms and Calculus
            newTime = Increase1Second(hours, minutes, seconds);

            //Output Values
            Console.WriteLine($"The time {hours:00}:{minutes:00}:{seconds:00} with a second added is {newTime}");
        }
    }
}
