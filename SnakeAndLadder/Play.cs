using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        public void Game()
        {
            int position = 0, Die = 0;
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
                Console.WriteLine("Playerposition---->" + Playerposition);
            }
        }
    }
}


