using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class RPSApp
    {
        public static HumanPlayer MakePlayer()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors! \nWhat is your Name? ");
            string name = Console.ReadLine();
            return new HumanPlayer(name);
        }


        public static IPlayer CPUPlayer()
        {
            Console.WriteLine("Who would you like to face?\n1 = Rocky (RockPlayer)\n2 = Randy (Random Player)");
            string choice = Console.ReadLine();
            while (choice != "1" && choice != "2")
            {
                Console.WriteLine("Sorry, " + choice + " is not an option. \nWho would you like to face?\n1 = Rocky (RockPlayer)\n2 = Randy (Random Player)");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case "1":
                    return new RockPlayer("Rocky");
                case "2":
                    return new RandomPlayer("Randy");
                default:
                    Console.WriteLine("Sorry something went wrong your answer is now Rocky!");
                    return new RockPlayer("Rocky");
            }
        }

        public static bool DoesPlayerWin(RPS player, RPS cpu)
        {
            if ((player == RPS.rock && cpu == RPS.scissors) ||
               (player == RPS.paper && cpu == RPS.rock) ||
               (player == RPS.scissors && cpu == RPS.paper))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void GameStart()
        {
            HumanPlayer player1 = MakePlayer();
            IPlayer cpu = CPUPlayer();
            RPS player_choice;
            RPS cpu_choice;
            bool done = false;
            int player_win = 0;
            int player_loses = 0;
            while (!done)
            {
                player_choice = player1.GenerateRPS();
                cpu_choice = cpu.GenerateRPS();
                Console.WriteLine("You: " + player_choice);
                Console.WriteLine("Opponent: " + cpu_choice);
                if (DoesPlayerWin(player_choice, cpu_choice))
                {
                    Console.WriteLine("You Win");
                    player_win++;
                }
                else
                {
                    Console.WriteLine("You Lose, Tie = Loss");
                    player_loses++;
                }
                Console.WriteLine("Your score: W:" + player_win + " L:" + player_loses);
                Console.WriteLine("Would you like to play again? \n 1= Yes or 2= No");
                string choice = Console.ReadLine();
                while (choice != "1" && choice != "2")
                {
                    Console.WriteLine("Sorry, " + choice + " is not an option. \nWould you like to play again? \n 1= Yes or 2= No");
                    choice = Console.ReadLine();
                }
                if (choice == "2")
                {
                    done = true;
                }
            }

            Console.WriteLine("Thanks for playing! Goodbye!");

        }
    }







}

