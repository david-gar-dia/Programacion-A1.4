namespace ex30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int month, day;

            //Initial Values
            Console.WriteLine("Write here the month of a date: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write here the day of a date: ");
            day = Convert.ToInt32(Console.ReadLine());

            //Algorithms and Calculus and Output Values
            if (day < 1 || day > 31 || month < 1 || month > 12)
                Console.WriteLine($"The date {day:00}/{month:00} is invalid");
            else if (month == 3 && day >= 21 || month == 4 || month == 5 || month == 6 && day <= 20)
                Console.WriteLine($"The date {day:00}/{month:00} belongs to Spring");
            else if (month == 6 && day >= 21 || month == 7 || month == 8 || month == 9 && day <= 20)
                Console.WriteLine($"The date {day:00}/{month:00} belongs to Summer");
            else if (month == 9 && day >= 21 || month == 10 || month == 11 || month == 12 && day <= 20)
                Console.WriteLine($"The date {day:00}/{month:00} belongs to Fall");
            else
                Console.WriteLine($"The date {day:00}/{month:00} belongs to Winter");
        }
    }
}
