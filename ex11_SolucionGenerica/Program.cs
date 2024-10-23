namespace ex11_SolucionGenerica
{
    internal class Program
    {
        static string WhichQuadrant(double angle)
        {
            int quadrant;
            string inform;

            angle = angle % 360;

            if (angle < 0)
                angle += 360;

            if (angle == 0 || angle == 90 || angle == 180 || angle == 270)
                inform = "The angle is found in an overlapped with an axis and has not one single given quadrant";
            else
            {
                quadrant = (int)angle / 90 + 1;
                inform = $"The angle is found in quadrant {quadrant}";
            }

            return inform;
        }
        static void Main(string[] args)
        {
            //Variable Declaration
            double givenAngle;
            string resultantQuadrant;

            //Initial Values
            Console.Write("Write here the desired angle: ");
            givenAngle = Convert.ToDouble(Console.ReadLine());

            //Algorithms and Calculus
            resultantQuadrant = WhichQuadrant(givenAngle);

            //Output Values
            Console.WriteLine(resultantQuadrant);
        }
    }
}
