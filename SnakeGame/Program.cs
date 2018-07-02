using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SNAKE 1.0";
            GameBoard board = new GameBoard();
            board.Board();
            Snake snake = new Snake();
            snake.Init();
            snake.Draw();
            snake.Animate();
        }
    }
}
