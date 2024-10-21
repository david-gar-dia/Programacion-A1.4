namespace ex06
{
    internal class Program
    {
        public static string InformOfResults(string nameLocalTeam, int localTeamGoals, string nameVisitorTeam, int visitorTeamGoals)
        {
            string inform;

            if (localTeamGoals > visitorTeamGoals)
                inform = $"Team {nameLocalTeam} has won against {nameVisitorTeam} with a result of {localTeamGoals} to {visitorTeamGoals}";
            else if (localTeamGoals < visitorTeamGoals)
                inform = $"Team {nameLocalTeam} has lost against {nameVisitorTeam} with a result of {localTeamGoals} to {visitorTeamGoals}";
            else
                inform = $"Team {nameLocalTeam} has tied against {nameVisitorTeam} with a result of {localTeamGoals} to {visitorTeamGoals}";

            return inform ;
        }

        static void Main(string[] args)
        {
            //Variable Declaration
            string localTeam, visitorTeam, result;
            int localGoals, visitorGoals;

            //Initial Values
            Console.Write("Write the name of the local team: ");
            localTeam = Console.ReadLine();
            Console.Write("And how many goals did they score?: ");
            localGoals = Convert.ToInt32(Console.ReadLine());
            Console.Write("Now write the name of the visitor team: ");
            visitorTeam = Console.ReadLine();
            Console.Write("And how many goals did they score?: ");
            visitorGoals = Convert.ToInt32(Console.ReadLine());

            //Algorhythms and Calculus
            result = InformOfResults(localTeam, localGoals, visitorTeam, visitorGoals);

            //Output Values
            Console.WriteLine($"{result}");
        }
    }
}
