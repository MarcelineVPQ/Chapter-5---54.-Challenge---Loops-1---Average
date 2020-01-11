using System;

namespace Chapter_5___54._Challenge___Loops_1___Average
{
    class Program
    {
        static void Main(string[] args)
        {
            AverageScore();
        }
        static void AverageScore()
        {
            double totalScore = 0;
            double averageScore = 0;
            int individualCounter = 1;
            
            Console.WriteLine("This program will allow you to enter the scores");
            Console.WriteLine("of twenty students and average their total score.");
            Console.WriteLine();
            
            do
            {
                Console.WriteLine("Enter Score Number {0} :", individualCounter);
                string scoreInsert = Console.ReadLine();
                double scorenumber = Int32.Parse(scoreInsert);
                totalScore += scorenumber;
                Console.WriteLine();
                Console.WriteLine("Total Score: {0}",totalScore);
                individualCounter++;
            }
            while (individualCounter < 21);
            averageScore = totalScore / 20;
            Console.WriteLine("The final total score was {0}, and the Average Score is: {1}", totalScore,averageScore);
            Console.Read();
        }

    }
}
