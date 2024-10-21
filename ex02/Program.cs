using System.Linq.Expressions;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given the next code, write the boolean expression necessary to determine that the three temperatures are the same

            int t1 = 25;
            int t2 = 25;
            int t3 = 25;
            bool iguals;

            //Here is where I wrote my answer:
            iguals = t1 == t2 && t2 == t3;
            
            if (iguals)
            {
                Console.WriteLine("Les tres temperatures són iguals.");
            }
            else
            {
                Console.WriteLine("Les temperatures no són iguals.");
            }

        }
    }
}
