using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class final_game
    {
        public int P1Position = 0;
        public int P2Position = 0;
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int Start = 0;
        public const int End = 100;
        public int Totaldiecount = 0;
        public int P1diecount = 0;
        public int P2diecount = 0;
        public void InitGame()
        {
            while (P1Position != 100 || P2Position != 100)
            {
                Random random = new Random();

                Player1Chance:
                int DieRolled = random.Next(1, 7);
                Console.Write(" Dice Rolled for Player1: {0} ", DieRolled);

                int Option1 = random.Next(0, 3);
                Console.WriteLine(" Move Option : " + Option1);

                Totaldiecount++;
                P1diecount++;

                switch (Option1)
                {
                    case No_Play:
                        Console.Write("No Move");
                        break;
                    case Ladder:
                        P1Position += DieRolled;
                        if (P1Position > 100)
                        {
                            P1Position -= DieRolled;
                            Console.WriteLine("Can't move ahead of 100");
                            break;
                        }
                        Console.WriteLine("Player1 got Ladder, New Position : {0}", P1Position);
                        goto Player1Chance;
                        //break;
                    case Snake:
                        P1Position -= DieRolled;
                        if (P1Position < 0)
                        { P1Position = Start; }
                        Console.WriteLine("Player1 got Snake, New Position : {0}", P1Position);
                        break;

                }

                Player2Chance:
                DieRolled = random.Next(1, 7);
                Console.Write(" Dice Rolled for Player2 : {0} ", DieRolled);

                int Option2 = random.Next(0, 3);
                Console.WriteLine(" Move Option : " + Option2);

                Totaldiecount++;
                P2diecount++;

                switch (Option2)
                {
                    case No_Play:
                        Console.Write("No Move");
                        break;
                    case Ladder:
                        P2Position += DieRolled;
                        if (P2Position > 100)
                        {
                            P2Position -= DieRolled;
                            Console.WriteLine("Can't move ahead of 100");
                            break;
                        }
                        Console.WriteLine("Player2 got Ladder, New Position : {0}", P2Position);
                        goto Player2Chance;
                        //break;
                    case Snake:
                        P2Position -= DieRolled;
                        if (P2Position < 0)
                        { P2Position = Start; }
                        Console.WriteLine("Player2 got Snake, New Position : {0}", P2Position);
                        break;

                }

            }

            if ( P1Position == 100)
            {
                Console.WriteLine("Player1 won the game");

            }
            else if( P2Position == 100)
            {
                Console.WriteLine("Player2 won the game");
            }

            Console.WriteLine("Total Number of Die thrown: " + Totaldiecount);
            Console.WriteLine("Total Number of Die thrown by Player1: " + P1diecount);
            Console.WriteLine("Total Number of Die thrown by Player2: " + P2diecount);


        }

    }
}
