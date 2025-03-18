using System.Security.Cryptography;

namespace Topic_1_7_Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum, wallet, userBet;
            string guess, choise;
            bool done = false;

            Console.WriteLine("Hello and welcome to my rock paper scissors game! :)");
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("This will include standard rules for rock paper scissors.");
            Console.WriteLine();
            Console.WriteLine("You will go against a computer and you will bet a certain amount each round and if you lose you get nothing but if you win you get what you bet back and if you tie, you dont lose or gain what you bet.");
            Console.WriteLine();
            Console.WriteLine("You will start with 5 dollars in your wallet to start and you bet 1 dollar per round. You can't bet nothing and you lose when your wallet hits 0.");
            Console.WriteLine();
            Console.WriteLine("Now without more delay, lets start the game");
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
            //Round 1 Below
            Console.WriteLine("let the games begin!:");
            Console.WriteLine("==============");
            Console.WriteLine();
            
            while (!done)
            {
                wallet = 5;
                randNum = generator.Next(1, 4);
                Console.WriteLine();
                Console.WriteLine("The computer has made it's choice.");
                Console.WriteLine();
                Console.Write("Now what is your choice (rock, paper or scissors)? ");
                // 1 - Rock
                // 2 - Paper
                // 3 = Scissors
                guess = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (guess == "paper")
                {
                    if (randNum == 1)
                    {
                        Console.WriteLine("The computer chose Rock!!");
                        Console.WriteLine("You won! As we know, paper beats rock.");
                        wallet = wallet + 1;
                    }
                    else if (randNum == 2)
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("You tied the computer, As we know, paper can't beat paper.");
                    }
                    else if (randNum == 3)
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("You lose! As we know, scissors beats paper.");
                        wallet = wallet - 1;
                    }
                }
                else if (guess == "rock")
                {
                    if (randNum == 1)
                    {
                        Console.WriteLine("The computer chose rock!!");
                        Console.WriteLine("You tied! As we know rock can't beat rock.");
                    }
                    else if (randNum == 2)
                    {
                        Console.WriteLine("The computer chose paper!!");
                        Console.WriteLine("You lose! As we know, paper beats rock.");
                        wallet = wallet - 1;
                    }
                    else if (randNum == 3)
                    {
                        Console.WriteLine("The computer chose scissors!!");
                        Console.WriteLine("You won! As we know, rock beats scissors.");
                        wallet = wallet + 1;
                    }
                }
                else if (guess == "scissors")
                {
                    if (randNum == 1)
                    {
                        Console.WriteLine("The computer chose rock!!");
                        Console.WriteLine("You lose! As we know, rock beats scissors.");
                        wallet = wallet - 1;
                    }
                    else if (randNum == 2)
                    {
                        Console.WriteLine("The computer chose paper!!");
                        Console.WriteLine("You won! As we know, scissors beats paper.");
                        wallet = wallet + 1;
                    }
                    else if (randNum == 3)
                    {
                        Console.WriteLine("The computer chose scissors!!");
                        Console.WriteLine("You tied! As we know, scissors can't beat scissors.");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Type 'y' to play again and press 'Enter' if you want to quit");
                Console.WriteLine();
                choise = Console.ReadLine().ToLower();
                if (choise != "y")
                {
                    Console.WriteLine("Thank you and have a nice day! :)");
                    done = true;
                }
            }
        }
     }
 }
