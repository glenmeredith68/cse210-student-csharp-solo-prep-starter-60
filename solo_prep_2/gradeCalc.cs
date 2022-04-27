using System;

namespace solo_prep_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your grade? ");
            string gradeString = Console.ReadLine();
            int gradeInt = int.Parse(gradeString);
            // determine letter grade and if passed
            char? letterGrade = null;
            if (gradeInt >= 90)
            {
                letterGrade = 'A';
            }
            else if (gradeInt >= 80)
            {
                letterGrade = 'B';
            }
            else if (gradeInt >= 70)
            {
                letterGrade = 'C';
            }
            else if (gradeInt >= 60)
            {
                letterGrade = 'D';
            }
            else if (gradeInt < 60)
            {
                letterGrade = 'F';
            }
            if (gradeInt >= 70)
            {
                Console.WriteLine($"You passed the class with a {letterGrade}. ");
            }
            else {
                Console.WriteLine($"You failed the class with a {letterGrade}. ");
            }
        }
    }
}
