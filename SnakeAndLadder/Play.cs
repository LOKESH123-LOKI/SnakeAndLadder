using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Play
    {
        int NO_PLAY, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int Playerposition = 0, count = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int die = random.Next(1, 7);
            Console.WriteLine("die value----->  " + die);
            count++;
            return die;
        }
        public void Game(int die, int option)
        {
            int position = 0;
            Play p = new Play();
            p.DieRoll();
            Random random = new Random();
            while (this.Playerposition < WINNING_POSITION)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        Playerposition += DieRoll();
                        break;
                    case SNAKE:
                        Playerposition -= DieRoll();
                        break;
                }
                return ();
            }
             public void MultiPlayer()
            {
                const int player1 = 1;
                int position1 = 0, position2 = 0;
                int player1 = 1;
                Play play = new Play();
                Random random = new Random();
                while (position1 < WINNING_POSITION && position2 < WINNING_POSITION)
                {
                    int die = p.DieRoll();
                    int option = random.Next(0, 3);
                    if (player == player1)
                    {
                        position1 += p.Game(int die, int option);
                        if (position1 > WINNING_POSITION)
                            position1 -= die;
                        if (option == LADDER)
                            player = 1;
                        else
                            player = 2;
                    }
                    else
                    {
                        position2 += p.Game(int die, int option);
                        if (position2 < WINNING_POSITION)
                            position2 -= die;
                        if (option == LADDER)
                            player = 2;
                        else
                            player = 1;
                    }
                }
                if (position1 == WINNING_POSITION)

                    Console.WriteLine("player1 won the game");
                else
                    Console.WriteLine("Player2 won the game");
            }
        }
    }
}