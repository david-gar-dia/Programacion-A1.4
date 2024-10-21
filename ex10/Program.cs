namespace ex10
{
    internal class Program
    {
        public static string Century(int year)
        {
            string valid;

            if (year >= 1700 && year < 2100)
                valid = $"The year {year} is valid";
            else
                valid = $"The year {year} is NOT valid";

            return valid;
        }
        static void Main(string[] args)
        {
            //Variable Declaration
            int givenYear;
            string validity;

            //Initial Values
            Console.Write("Enter a year: ");
            givenYear = Convert.ToInt32(Console.ReadLine());

            //Algorithms and Calculus
            validity = Century(givenYear);

            //Output Values
            Console.WriteLine(validity);
        }
    }
}
