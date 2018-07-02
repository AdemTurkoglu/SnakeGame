using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Snake
    {
        
         
        private Queue<Node> queue;
        private int deltaX;
        private int deltaY;
        private Node headNode;
        private bool control = true;
        Engine e = new Engine();
    

        public Snake()
        {
            queue = new Queue<Node>();
            deltaX = 1;
            deltaY = 0;
        }
        public void Init()
        {
            for (int i = 0; i < 5; i++)
            {
                Node n = new Node(10 + i, 5);
                headNode = n;
                queue.Enqueue(n);
            }
        }
        public void Draw()
        {
            foreach (Node n in queue)
            {
                Console.SetCursorPosition(n.X, n.Y);
                Console.Write("#");
            }
            e.Yem();

        }
        public void Animate()
        {
            while (true)
            {
                Keybutton();
                Node n = new Node(headNode.X + deltaX, headNode.Y + deltaY);
                headNode = n;
                GameOver();
                if (control == false) break;
                queue.Enqueue(n);
                n.Kenar(n.X, n.Y);
                if (headNode.X == e.RX && headNode.Y == e.RY)
                {
                    e.score += e.yem;
                    for (int i = 0; i < e.yem; i++)
                    {
                        queue.Enqueue(n);
                    }
                    e.Yem();
                    Console.SetCursorPosition(69, 22);
                    Console.Write(" SCORE: " + e.score);
                }
                Console.SetCursorPosition(n.X, n.Y);
                Console.Write("#");

                Node kuyrukNode = queue.Dequeue();
                Console.SetCursorPosition(kuyrukNode.X, kuyrukNode.Y);
                Console.Write(" ");
                System.Threading.Thread.Sleep(100);

            }
        }
        public void GameOver()
        {
            foreach (Node n in queue)
            {
                if (n.X == headNode.X && n.Y == headNode.Y)
                {
                    Console.Clear();
                    GameBoard bitir = new GameBoard();
                    bitir.Finish(e.score);
                    control = false;
                    break;
                }
            }
        }

        public void Keybutton()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tus = Console.ReadKey(true);

                if (tus.Key.Equals(ConsoleKey.UpArrow) && deltaY != 1)
                {
                    deltaX = 0;
                    deltaY = -1;

                }
                if (tus.Key.Equals(ConsoleKey.DownArrow) && deltaY != -1)
                {

                    deltaX = 0;
                    deltaY = 1;

                }
                if (tus.Key.Equals(ConsoleKey.LeftArrow) && deltaX != 1)
                {
                    deltaX = -1;
                    deltaY = 0;

                }
                if (tus.Key.Equals(ConsoleKey.RightArrow) && deltaX != -1)
                {
                    deltaX = 1;
                    deltaY = 0;
                }
            }
            else if (Console.KeyAvailable)
            {
                deltaX = 1;
                deltaY = 0;

            }
        }

        }

    }
