using System;
namespace SnakeAndLadder
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder game");
            Play play = new Play();
            Console.WriteLine("the die is :" + play.DieRoll);
            play.Game();
        }
    }
}