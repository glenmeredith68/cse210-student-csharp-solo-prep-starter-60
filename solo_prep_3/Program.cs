using System;

namespace solo_prep_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randObj = new Random();
             int randNum = randObj.Next(1,10);

             int userGuessInt = 0;

             while (userGuessInt != randNum) {
                 Console.Write("What is your guess? ");
                 userGuessInt = int.Parse(Console.ReadLine());
                 if (userGuessInt == randNum) {
                     Console.WriteLine("Correct! You win ");
                 }
                 else if (userGuessInt > randNum) {
                     Console.WriteLine("Lower. Try again ");
                 }
                 else if (userGuessInt < randNum) {
                     Console.WriteLine("Higher. Try again ");
                 }
             }

        }
    }
}
