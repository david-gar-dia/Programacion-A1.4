namespace ex13
{
    internal class Program
    {
        static bool IsPalindrome(int number)
        {
            bool isPalindrome;
            int firstNumber, secondNumber, thirdNumber, lastNumber;

            firstNumber = number / 1000;
            secondNumber = number / 100 % 10;
            thirdNumber = number / 10 % 10;
            lastNumber = number % 10;

            if(firstNumber != lastNumber || secondNumber != thirdNumber)
                isPalindrome = false;
            else
                isPalindrome = true;

            return isPalindrome;
        }
        static void Main(string[] args)
        {
            //Variable Declaration
            int givenNumber;

            //Initial Values
            Console.Write("Type here the four-digit number you want to check: ");
            givenNumber = Convert.ToInt32(Console.ReadLine());

            //Algortihms, Calculus and Output Values
            if (IsPalindrome(givenNumber))
                Console.WriteLine($"The number {givenNumber:0000} is a palindrome");
            else
                Console.WriteLine($"The number {givenNumber:0000} is not a palindrome");
        }
    }
}
