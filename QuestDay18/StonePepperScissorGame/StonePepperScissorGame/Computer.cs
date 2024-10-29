using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePepperScissorGame
{
    internal class Computer
    {
        private Random random = new Random();

        public Move GetMove()
        {
            return (Move)random.Next(0, 3);
        }
        public int Score { get; private set; }

        public void IncreaseScore()
        {
            Score++;
        }
    }
}
