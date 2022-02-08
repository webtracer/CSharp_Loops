using System;

namespace Loops___Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int finished = 0;
            double numScores = 0;
            double avgScore;
            double scores = 0;
            int temp_score;
            string userContinue;

            while (finished != -1)
            {
                string userInput;

                Console.WriteLine("Please enter the students score: ");
                userInput = Console.ReadLine();
                
                try
                {
                    temp_score = int.Parse(userInput);
                    if(temp_score > 20 || temp_score < -1)
                    {
                        Console.WriteLine("You did not enter a valid test score");
                    }
                    else
                    {
                        scores += temp_score;
                    }
                    // if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                    // that is a valid if statement with multiple conditions in it
                }
                catch(FormatException)
                {
                    //throw;
                    Console.WriteLine("You have entered an invalid score, please try again");
                }

                Console.WriteLine("Would you like to enter another score?  Y for yes, -1 for no");
                userContinue = Console.ReadLine();

                if (userContinue == "-1")
                {
                    finished = -1;
                }
                else
                {
                    numScores++;
                }
            }

            avgScore = scores / numScores;

            Console.WriteLine($"The average score for {numScores} students is {avgScore}");
        }
    }
}
