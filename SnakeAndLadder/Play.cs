using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Play
    {
        int NO_PLAY, Ladder = 1;
        int Playerposition = 0, count = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int die = random.Next(1, 7);
            Console.WriteLine("die value----->  " + die);
            count++;
            return die;
        }
    }
}



