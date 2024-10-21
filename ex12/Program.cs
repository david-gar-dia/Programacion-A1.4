
namespace ex12
{
    internal class Program
    {
        static bool IsLeap(int year)
        {
            bool isLeap;

            if (year % 400 == 0)
                isLeap = true;
            else if (year % 100 == 0)
                isLeap = false;
            else if (year % 4 == 0)
                isLeap = true;
            else
                isLeap = false;

            return isLeap;
        }
        static void Main(string[] args)
        {
            //Variable Declaration
            int givenYear;

            //Initial Values
            Console.Write("Write here the wished year: ");
            givenYear = Convert.ToInt32(Console.ReadLine());

            //Algorithms and Calculus and Output Values
            if (IsLeap(givenYear))
                Console.WriteLine($"The year {givenYear} is a leap year");
            else
                Console.WriteLine($"The year {givenYear} is not a leap year");
        }
    }
}
