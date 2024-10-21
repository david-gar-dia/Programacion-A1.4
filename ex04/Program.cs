using System.Linq.Expressions;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given the next code, write the boolean expression necessary to determine that the three temperatures are in crescent order
            int t1 = 24;
            int t2 = 25;
            int t3 = 26;
            bool ordreCreixent;

            //Here I write my solution (I define crescent temperatures if, when defined on a graphic, the line that traces the three points does never have decrescent graph slope):
            ordreCreixent = t1 < t3 && t1 <= t2 && t2 < t3;
            
            if (ordreCreixent)
            {
                Console.WriteLine("Les temperatures estan en ordre creixent estricte.");
            }
            else
            {
                Console.WriteLine("Les temperatures no estan en ordre creixent estricte.");
            }

        }
    }
}
