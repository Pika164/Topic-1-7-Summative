using System.Security.Cryptography;

namespace Topic_1_7_Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum, wallet, bet, gameEnd;
            string guess, choise;
            bool done = false;
            bool doneBet = false;

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
                gameEnd = 0;
                wallet = 15;
                randNum = generator.Next(1, 4);
                Console.WriteLine();
                Console.WriteLine("The computer has made it's choice.");
                Console.WriteLine();
                Console.Write("Now what is your choice (rock, paper or scissors)? ");
                guess = Console.ReadLine().ToLower();
                // 1 - Rock
                // 2 - Paper
                // 3 = Scissors
                Console.ReadLine();
                Console.WriteLine();
                Console.Write("Now enter a bet from 1 to 5: ");
                bet = Convert.ToInt32(Console.ReadLine());
                doneBet = true;
                Console.WriteLine();

                while (!doneBet)
                {
                    Console.WriteLine();
                    Console.Write("Now enter a bet from 1 to 5: ");
                    bet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (bet <= wallet)
                    {
                        doneBet = true;
                    }
                    else if (bet > wallet)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You bet more than you have.");
                        bet = wallet;
                    }
                    else if (bet < 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You can't bet a negative number, making bet 0.");
                        bet = 0;  
                    }
                }

                if (guess == "paper")
                {
                    if (randNum == 1)
                    {
                        Console.WriteLine("The computer chose Rock!!");
                        Console.WriteLine();
                        Console.WriteLine("You won! As we know, paper beats rock.");
                        Console.WriteLine();
                        Console.WriteLine("You won your bet back which was " + bet + " Dollars");
                        wallet = wallet + bet;
                    }
                    else if (randNum == 2)
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine();
                        Console.WriteLine("You tied the computer, As we know, paper can't beat paper.");
                    }
                    else if (randNum == 3)
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine();
                        Console.WriteLine("You lose! As we know, scissors beats paper.");
                        Console.WriteLine();
                        Console.WriteLine("You lost your bet which was " + bet + " Dollars");
                        wallet = wallet - bet;
                    }
                }
                else if (guess == "rock")
                {
                    if (randNum == 1)
                    {
                        Console.WriteLine("The computer chose rock!!");
                        Console.WriteLine();
                        Console.WriteLine("You tied! As we know rock can't beat rock.");
                    }
                    else if (randNum == 2)
                    {
                        Console.WriteLine("The computer chose paper!!");
                        Console.WriteLine();
                        Console.WriteLine("You lose! As we know, paper beats rock.");
                        Console.WriteLine();
                        Console.WriteLine("You lost your bet which was " + bet + " Dollars");
                        wallet = wallet - bet;
                    }
                    else if (randNum == 3)
                    {
                        Console.WriteLine("The computer chose scissors!!");
                        Console.WriteLine();
                        Console.WriteLine("You won! As we know, rock beats scissors.");
                        Console.WriteLine();
                        Console.WriteLine("You won your bet back which was " + bet + " Dollars");
                        wallet = wallet + bet;
                    }
                }
                else if (guess == "scissors")
                {
                    if (randNum == 1)
                    {
                        Console.WriteLine("The computer chose rock!!");
                        Console.WriteLine();
                        Console.WriteLine("You lose! As we know, rock beats scissors.");
                        Console.WriteLine();
                        Console.WriteLine("You lost your bet which was " + bet + " Dollars");
                        wallet = wallet - bet;

                    }
                    else if (randNum == 2)
                    {
                        Console.WriteLine("The computer chose paper!!");
                        Console.WriteLine();
                        Console.WriteLine("You won! As we know, scissors beats paper.");
                        Console.WriteLine();
                        Console.WriteLine("You won your bet back which was " + bet + " Dollars");
                        wallet = wallet + bet;
                    }
                    else if (randNum == 3)
                    {
                        Console.WriteLine("The computer chose scissors!!");
                        Console.WriteLine();
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
