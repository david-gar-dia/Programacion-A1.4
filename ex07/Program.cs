using System.Text;

namespace ex07
{
    internal class Program
    {
        public static string Fine(int speed)
        {
            string fine;

            if (speed < 80)
                fine = "No fine";
            else if (speed < 99)
                fine = "100$ fine";
            else if (speed < 129)
                fine = "300$ fine";
            else
                fine = "600$ fine + loss of license";

            return fine;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Variable Declaration
            string fineMessage;
            int velocity;

            //Initial Values
            Console.Write("What speed was the driver going?: ");
            velocity = Convert.ToInt32(Console.ReadLine());

            //Algorhythms and Calculus
            fineMessage = Fine(velocity);

            //Output Values
            Console.WriteLine($"{fineMessage}");
        }
    }
}
