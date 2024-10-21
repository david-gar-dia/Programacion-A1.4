namespace ex11
{
    internal class Program
    {
        static string WhichQuadrant(double angle)
        {
            int quadrant;
            string inform;

            if (angle <= -360 || angle >= 360)
                inform = "The angle provided is not inside the given range";
            else if (angle == 0 || angle == 90 || angle == 180 || angle == 270)
                inform = "The angle is found in an overlapped with an axis and has not one single given quadrant";
            else
            {
                if (angle < 0 && angle > -360)
                    angle += 360;
                quadrant = (int) angle / 90 + 1;
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
