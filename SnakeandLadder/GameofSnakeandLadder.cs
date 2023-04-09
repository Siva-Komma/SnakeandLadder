using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class GameofSnakeandLadder
    {
        public static void Game()
        {
            int Position = 0;
            Console.WriteLine($"Player Position: {Position}");
            Random random = new Random();
            int die = random.Next(1, 7);
            Console.WriteLine("Random Number: " + die);
        }
    }
}
