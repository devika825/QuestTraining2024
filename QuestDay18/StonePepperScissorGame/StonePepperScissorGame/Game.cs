using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePepperScissorGame
{
    public class Game
    {
        private Player player = new Player();
        private Computer computer = new Computer();
        private const int WinningScore = 10;

        public void Play()
        {
            Console.WriteLine("Welcome to Stone-Paper-Scissors Game!");

            while (player.Score < WinningScore && computer.Score < WinningScore)
            {
                Move playerMove = player.GetMove();
                Move computerMove = computer.GetMove();

                Console.WriteLine($"Computer chose: {computerMove}");
                DetermineRoundWinner(playerMove, computerMove);

                Console.WriteLine($"Scores => Player: {player.Score}, Computer: {computer.Score}");
            }

            if (player.Score >= WinningScore)
                Console.WriteLine("Congratulations! You won the game!");
            else
                Console.WriteLine("Computer won the game. Better luck next time!");
        }

        private void DetermineRoundWinner(Move playerMove, Move computerMove)
        {
            if (playerMove == computerMove)
            {
                Console.WriteLine("It's a draw!");
            }
            else if ((playerMove == Move.Stone && computerMove == Move.Scissors) ||
                     (playerMove == Move.Paper && computerMove == Move.Stone) ||
                     (playerMove == Move.Scissors && computerMove == Move.Paper))
            {
                Console.WriteLine("You win this round!");
                player.IncreaseScore();
            }
            else
            {
                Console.WriteLine("Computer wins this round!");
                computer.IncreaseScore();
            }
        }

    }
}
