namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given the variables:
            int a, b, c;

            a = 5;
            b = 3;
            c = -10;

            //Evaluate the result of the next 10 boolean expressions

            /*
                a > 3 is true
                a > c is true
                b != c is true
                a == 3 is false
                a * b == 15 is true
                c / b < a is true
                c / b == -10 is false
                a + b + c == 5 is false
                (a + b == 8) && (a - b == 2) is true
                (a + b == 8) || (a - b == 6) is true
                a > 3 && b > 3 && c < 3 is false
            */

            //In the following lines we have the proves for the exercise

            if (a > 3)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if (a > c)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if (b != c)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if (a == 3)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if (a* b == 15)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if (c / b < a)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if (c / b == -10)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if (a + b + c == 5)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if ((a + b == 8) && (a - b == 2))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if ((a + b == 8) || (a - b == 6))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            if (a > 3 && b > 3 && c < 3)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
