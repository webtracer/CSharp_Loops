using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Loop - Great for counters
            // for(start value; condition; increment)
            // {
            //      code body
            // }

            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
            }

            for(int counter = 0; counter < 50; counter += 5)
            {
                Console.WriteLine(counter);
            }

            //small challenge - for loop that only prints odd numbers
            for(int counter = 0; counter < 20; counter++)
            {
                if(counter % 2 != 0)
                {
                    Console.WriteLine(counter);
                }
            }

            // OR
            for(int counter = 1; counter < 20; counter += 2)
            {
                Console.WriteLine(counter);
            }

            // While Loop - executes code while conditon is met
            // counterVariable = 0;
            //while(condition)
            //{
            //      execute your code
            //      counterVariable++;
            //}

            int counterWhile = 0;

            while(counterWhile < 10)
            {
                Console.WriteLine($"The While counter is {counterWhile}");
                counterWhile++;
            }

            int peopleCounter = 0;
            string allAboard = "";

            while (allAboard  == "")
            {
                Console.Write("Please press enter to count people:");
                allAboard = Console.ReadLine();
                if (allAboard == "")
                {
                    Console.WriteLine($"The number of people is currently {peopleCounter}");
                    peopleCounter++;
                }
                else
                {
                    Console.WriteLine("Everyone is on board, have a great trip!");
                }
            }


            // Do While Loop - executes as long as the condition is met
            // counterVariable = 0;
            // do
            // {
            //       execute your code 
            //      counterVariable++;
            // }while(condition)   - will run at least once before condition is checked

            int counterDo = 0;

            do
            {
                Console.WriteLine($"The Do While counter is {counterDo}");
                counterDo++;
            } while (counterDo < 10);

            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend:");
                string nameOfFriend = Console.ReadLine();
                int currentLength = nameOfFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfFriend + ", ";
            } while (lengthOfText < 20);
            Console.WriteLine("THat is enough names for now, thank you!");
            Console.WriteLine($"Your friends: {wholeText}");

            // break and continue

            for(int counterBreak = 0; counterBreak < 10; counterBreak++)
            {
                Console.WriteLine(counterBreak);
                if(counterBreak == 3)
                {
                    Console.WriteLine("The code 'breaks' at 3");
                    break;
                }
            }
            Console.WriteLine("This is outside of the for loop and the last number should be 3");

            for(int counterContinue = 0; counterContinue < 10; counterContinue++)
            {
                if(counterContinue % 2 == 0)
                {
                    Console.WriteLine("THe next number is odd");
                    continue;
                }
                Console.WriteLine(counterContinue);
            }

            //  foreach Loop
            //  runs through an array
            //  only runs as long as there is content
            // Explained in the Arrays chapter

            Console.WriteLine("Hello World!");
        }
    }
}
