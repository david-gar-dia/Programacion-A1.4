namespace ex09
{
    internal class Program
    {
        public static string QualitativeGrade(double examGrade, double practiceGrade)
        {
            string result;
            double average;

            average = examGrade * 0.8 + practiceGrade * 0.2;

            if (examGrade < 3 || practiceGrade < 3 || average < 5)
                result = "Failed";
            else if (average < 7)
                result = "Passed";
            else if (average < 9)
                result = "Good";
            else if (average <= 10)
                result = "Excellent";
            else
                result = "The grades assigned are not valid";

            return result;
        }
        static void Main(string[] args)
        {
            //Variable Declaration
            double gradeForExam, gradeForPractice;
            string qualification;

            //Initial Values
            Console.Write("Enter the grade obtained for the exam: ");
            gradeForExam = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the grade obtained for the practice: ");
            gradeForPractice = Convert.ToDouble(Console.ReadLine());

            //Algorythms and Calculus
            qualification = QualitativeGrade(gradeForExam, gradeForPractice);

            //Output Values
            Console.WriteLine(qualification);
        }
    }
}
