using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class DieRoll
    {
        public int P1Position = 0;

        public void InitGame()
        {
            Random random = new Random();
            int DieRolled = random.Next(1, 7);
            Console.Write(" Dice Rolled : {0} ", DieRolled);
        }
        
    }
}
