using System.Security.Cryptography;

namespace Topic_1_7_Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum;
            string guess;


            Console.WriteLine("Hello and welcome to my rock paper scissors game! :)");
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("This will include standard rules and you have to win and if you lose so many times, you have to restart");
            Console.WriteLine();
            Console.WriteLine("Your guesses will be numbers from 1 - 3: 1 is rock 2 is paper and 3 is scissors.");
            Console.WriteLine();
            Console.WriteLine("Now without more delay, lets start the game");
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
            //Round 1 Below
            randNum = generator.Next(1, 4);
            Console.WriteLine("Round 1:");
            Console.WriteLine("==============");
            Console.WriteLine();
            Console.WriteLine("tHE COMPUTER HAS mADE ITS CHOICE.");
            Console.WriteLine();
            Console.WriteLine("Now what is your choice (rock, paper or scissors)? ");
            // 1 - Rock
            // 2 - Paper
            // 3 = Scissors
            Console.WriteLine();
            guess = Console.ReadLine().ToLower();
            Console.WriteLine();
            
            if (guess == "scissors")
            {
                if (randNum == 1)
                {
                    Console.WriteLine("The computer chose Rock!!");
                    Console.WriteLine("You won! As we know, paper beats rock");
                }
                else if (randNum == 2)
                {


                }
                
            }
            else if (guess == 3 && randNum == 2)
            {
                Console.WriteLine("You got it right! " + "The number you guessed is " + guess + " And the random number is " + randNum + " And as we know, scissors beats paper");
            }
            else if (guess == 1 && randNum == 3)
            {
                Console.WriteLine("You got it right! " + "The number you guessed is " + guess + " and the random number is " + randNum + " and as we know, rock beats scissors.");
            }
            else
            {
                Console.WriteLine("You got it wrong! " + "The number you guessed is " + guess + " and the random num is " + randNum + " and as we know, your guess doesnt win against the random number");
            }
        }
    }
}
