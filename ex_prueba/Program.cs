namespace ex_prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int grade;

            //Initial Values
            Console.Write("Enter the grade you wanna check: ");
            grade = Convert.ToInt32(Console.ReadLine());

            //Algorythms and Calculus

            //Output Values
            if (grade > 10 || grade < 0)
                Console.WriteLine("Error note");
            else if (grade < 5)
                Console.WriteLine("Failed");
            else if (grade < 7)
                Console.WriteLine("Passed");
            else if (grade < 9)
                Console.WriteLine("Good");
            else
                Console.WriteLine("Excellent");
        }
    }
}
