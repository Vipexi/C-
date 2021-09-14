using System;

namespace NukeNuke
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int computer_wins =0;
            int player_wins =0;
            int ties =0;
            int games_played;

            while(true)
            {
                Random random = new Random();

                int computer = random.Next(1,4);
                Console.WriteLine("Cockroach-Foot-Nuke. Choose 1-4.");
                Console.WriteLine("1) Cockroach 2) Foot 3) Nuke 4) Exit");
                int choise = Convert.ToInt32(Console.ReadLine());
                
                if( choise == computer)
                {
                    Console.WriteLine($"You chose {choise} and the computer chose {computer}. It is a tie!");
                    ties++;
                }

                else if(choise == 2 && computer ==1)
                {
                    Console.WriteLine($"You chose {choise} and the computer chose {computer}. You win!");
                    player_wins++;
                }

                else if(choise == 3 && computer ==2)
                {
                    Console.WriteLine($"You chose {choise} and the computer chose {computer}. You win!");
                    player_wins++;
                }

                else if(choise == 1 && computer ==3)
                {
                    Console.WriteLine($"You chose {choise} and the computer chose {computer}. You win!");
                    player_wins++;
                }

                else if(choise == 1 && computer ==2)
                {
                    Console.WriteLine($"You chose {choise} and the computer chose {computer}. Computer win!");
                    computer_wins++;
                }

                else if(choise == 2 && computer ==3)
                {
                    Console.WriteLine($"You chose {choise} and the computer chose {computer}. Computer win!");
                    computer_wins++;
                }

                else if(choise == 3 && computer ==1)
                {
                    Console.WriteLine($"You chose {choise} and the computer chose {computer}. Computer win!");
                    computer_wins++;
                }

                else
                {
                    games_played=computer_wins + player_wins + ties;
                    Console.WriteLine($"The game was played {games_played} times. You won {player_wins} times, the computer won {computer_wins} times and ties {ties} times");
                    Console.WriteLine($"Goodbye!");
                    break;
                }
            }

            
        }
    }
}
