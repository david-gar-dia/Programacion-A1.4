namespace ex05
{
    internal class Program
    {
        public static bool IsEven(int n)
        {
            bool is_even;

            if (n % 2 == 0)
                is_even = true;
            else
                is_even = false;

            return is_even; 
        }
        public static bool IsMultipleOf7(int n)
        {
            bool is_multiple;

            if (n % 7 == 0)
                is_multiple = true;
            else
                is_multiple = false;

            return is_multiple;
        }
        static void Main(string[] args)
        {
            //Variable Declaration
            int number;
            bool even, mult7;
            //Initial Values
            Console.Write("Write a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            //Algorythms and Calculus
            even = IsEven(number);
            mult7 = IsMultipleOf7(number);

            //Output Values
            if (even)
                Console.WriteLine($"The number {number} is even");
            else
                Console.WriteLine($"The number {number} is odd");

            if (mult7)
                Console.WriteLine($"The number {number} is a multiple of 7");
            else
                Console.WriteLine($"The number {number} is not a multiple of 7");
        }
    }
}
