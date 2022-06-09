using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class CheckOption
    {
        public int P1Position = 0;
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public void InitGame()
        {
            Random random = new Random();
            int DieRolled = random.Next(1, 7);
            Console.Write(" Dice Rolled : {0} ", DieRolled);

            int Option1 = random.Next(0, 3);
            Console.WriteLine(" Move Option : " + Option1);

            switch(Option1)
            {
                case No_Play: Console.Write("No Move");
                    break;
                case Ladder:
                        P1Position += DieRolled;
                        Console.WriteLine("Player1 got Ladder, New Position : {0}", P1Position);
                    break;
                case Snake:
                        P1Position -= DieRolled;
                        Console.WriteLine("Player1 got Snake, New Position : {0}", P1Position);
                    break;
                
            }
    }
        
    }
}
