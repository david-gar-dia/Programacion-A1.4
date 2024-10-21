namespace ex13
{
    internal class Program
    {
        static bool IsPalindrome(int number)
        {
            bool isPalindrome;
            int firstNumber, lastNumber;

            firstNumber = number / 100;
            lastNumber = number % 10;

            isPalindrome = firstNumber == lastNumber;

            return isPalindrome;
        }
        static void Main(string[] args)
        {
            //Variable Declaration
            int givenNumber;

            //Initial Values
            Console.Write("Type here the three-digit number you want to check: ");
            givenNumber = Convert.ToInt32(Console.ReadLine());

            //Algortihms, Calculus and Output Values
            if (IsPalindrome(givenNumber))
                Console.WriteLine($"The number {givenNumber:000} is a palindrome");
            else
                Console.WriteLine($"The number {givenNumber:000} is not a palindrome");
        }
    }
}
