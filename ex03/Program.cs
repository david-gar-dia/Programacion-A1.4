using System.Linq.Expressions;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given the next code, write the boolean expression necessary to determine that the three temperatures are all different
            int t1 = 25;
            int t2 = 25;
            int t3 = 24;
            bool diferents;
            
            //Here I wrote my answer:
            diferents = t1 != t2 && t2 != t3 && t3 != t1;
            
            if (diferents)
            {
                Console.WriteLine("Les tres temperatures són totes diferents.");
            }
            else
            {
                Console.WriteLine("Les temperatures no són totes diferents.");
            }

        }
    }
}
