using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class reportDie
    {
        public int P1Position = 0;
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int Start = 0;
        public const int End = 100;
        public int diecount = 0;
        public void InitGame()
        {
            while (P1Position != 100)
            {


                Random random = new Random();
                int DieRolled = random.Next(1, 7);
                Console.Write(" Dice Rolled : {0} ", DieRolled);

                int Option1 = random.Next(0, 3);
                Console.WriteLine(" Move Option : " + Option1);

                diecount++;

                switch (Option1)
                {
                    case No_Play:
                        Console.Write("No Move");
                        break;
                    case Ladder:
                        P1Position += DieRolled;
                        if (P1Position>100)
                        {
                            P1Position -= DieRolled;
                            Console.WriteLine("Can't move ahead of 100");
                            break;
                        }
                        Console.WriteLine("Player1 got Ladder, New Position : {0}", P1Position);
                        break;
                    case Snake:
                        P1Position -= DieRolled;
                        if(P1Position < 0)
                        { P1Position = Start;  }
                        Console.WriteLine("Player1 got Snake, New Position : {0}", P1Position);
                        break;

                }
            
            }

            Console.WriteLine("Total Number of Die thrown: " + diecount);        
        }
        
    }
}
