using System;

namespace Rock_Paper_Scissors_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool playAgain = true;
            string answer;
            string playerChoice;
            string computerChoice;

            while (playAgain)
            {
                playerChoice = "";
                computerChoice = "";
                answer = "";

                while (playerChoice != "ROCK" && playerChoice != "PAPER" && playerChoice != "SCISSORS")
                {
                    Console.Write("Choose!, ROCK, PAPER, SCISSOR: ");
                    
                    playerChoice = Console.ReadLine();
                    playerChoice = playerChoice.ToUpper();
                }

                int randomNumber = random.Next(1, 4);
                switch (randomNumber)
                {
                    case 1:
                        computerChoice = "ROCK";
                        break;
                    case 2:
                        computerChoice = "PAPER";
                        break ;
                    case 3:
                        computerChoice = "SCISSORS";
                        break;
                 
                }
                Console.WriteLine();
                Console.WriteLine("Player: " + playerChoice);
                Console.WriteLine("Computer: " + computerChoice);
                Console.WriteLine();

                switch (playerChoice)
                {
                    case "ROCK":
                        if(computerChoice == "ROCK")
                        {
                            Console.WriteLine("It is a DRAW!");
                        }
                        else if(computerChoice == "PAPER")
                        {
                            Console.WriteLine("You LOST!");
                        }
                        else
                        {
                            Console.WriteLine("You WIN!");
                        }
                        break;
                    case "PAPER":
                        if (computerChoice == "PAPER")
                        {
                            Console.WriteLine("It is a DRAW!");
                        }
                        else if(computerChoice == "ROCK")
                        {
                            Console.WriteLine("You WIN!");
                        }
                        else
                        {
                            Console.WriteLine("You LOST!");
                        }
                        break ;
                    case "SCISSORS":
                        if(computerChoice == "SCISSORS")
                        {
                            Console.WriteLine("It is a DRAW!");
                        }
                        else if(computerChoice == "PAPER")
                        {
                            Console.WriteLine("You WON!");
                        }
                        else
                        {
                            Console.WriteLine("You LOST!");
                        }
                        break;
                }
                Console.WriteLine("Would you like to play again? (Y/N)");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if(answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
                
            }
            Console.WriteLine("Bye!");
            Console.ReadKey();

        }
    }
}
