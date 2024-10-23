namespace ex16
{
    internal class Program
    {
        static bool IsLeap(int year)
        {
            bool isLeap;

            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                isLeap = true;
            else
                isLeap = false;

            return isLeap;
        }
        static bool IsHulukuluYear(int year)
        {
            bool isHulukuluYear;

            if (year % 15 == 0)
                isHulukuluYear = true;
            else
                isHulukuluYear = false;

            return isHulukuluYear;
        }
        static bool IsBulukuluYear(int year)
        {
            bool isBulukuluYear;

            if (year % 55 == 0 && IsLeap(year))
                isBulukuluYear = true;
            else
                isBulukuluYear = false;

            return isBulukuluYear;
        }
        static void Main(string[] args)
        {
            //Variable Declaration
            int numProperties, year;

            //Initial Values;
            numProperties = 0;

            Console.Write("Write here the year you wanna check: ");
            year = Convert.ToInt32(Console.ReadLine());

            //Algorithms and Calculus

            if (IsLeap(year))
            {
                numProperties++;
                Console.Write("Leap");
            }
            if (IsHulukuluYear(year))
            {
                numProperties++;
                if (numProperties == 2)
                    Console.Write("-->");
                Console.Write("Hulukulu");
            }
            if (IsBulukuluYear(year))
            {
                numProperties++;
                if (numProperties >= 2)
                    Console.Write("-->");
                Console.WriteLine("Bulukulu");
            }
            if (numProperties == 0)
                Console.WriteLine("This is a normal year");
        }
    }
}
