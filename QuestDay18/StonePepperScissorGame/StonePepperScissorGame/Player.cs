using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePepperScissorGame
{
   public class Player
    {
        public int Score { get; set; }

        public void IncreaseScore()
        {
            Score++;
        }

        public Move GetMove()
        {
            int choice;
            do
            {
                Console.WriteLine("Enter your move (0 for Stone, 1 for Paper, 2 for Scissors):");

                string input = Console.ReadLine();

                if (int.TryParse(input, out choice) && choice >= 0 && choice <= 2)
                {
                    return (Move)choice;
                }

                Console.WriteLine("Invalid input. Please enter a number: 0, 1, or 2.");

            } 
            while (true);
        }
    }
}
