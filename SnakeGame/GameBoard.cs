using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class GameBoard
    {
        public void Board()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int y = 77;
            Console.Write('╔');
            for (int i = 0; i < 78; i++)
            {
                if (i == 33)
                {
                    Console.Write(" SNAKE 1.0 ");
                    i += 11;
                }
                Console.Write('═');

            }
            Console.Write('╗');

            for (int i = 0; i < 21; i++)
            {
                Console.Write('║');
                for (int j = 0; j < 78; j++)
                {
                    Console.Write(" ");
                }
                Console.Write('║');
            }
            Console.Write('╚');
            for (int i = 0; i < 78; i++)
            {
                Console.Write('═');
            }
            Console.WriteLine('╝');


            Console.ForegroundColor = ConsoleColor.Green;

        }
        public void Menu()
        {

        }
        public void Finish(int score)
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            for (int i = 0; i < 1; i++)
            {
                foreach (var color in colors)
                {
                    Console.SetCursorPosition(60, 5);
                    Console.ForegroundColor = color;
                    //  Console.Clear();

                    Console.WriteLine("\n                                 Game over :(");
                    Console.WriteLine("\n\n                               Your Score --> {0} !", score);
                    System.Threading.Thread.Sleep(100);
                }
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\n\n\n\n\n\n                          -- Press Enter To Exit --");
            System.Threading.Thread.Sleep(500);
            Console.Read();

        }
    }
}

