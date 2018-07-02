using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SnakeGame
{
    internal class Engine
    {
        public Engine()
        { }
                public int yem;
        public int score = 0;
        private int Rx;
        private int Ry;
    
    
        public int RX
        {
            get
            {
                return Rx;
            }
        }
        public int RY
        {
            get
            {
                return Ry;
            }
        }
        Random Rndm;
        public void Yem()
        {
            Rndm = new Random();
            yem = Rndm.Next(1, 5);
            Rx = Rndm.Next(1, 78);
            Ry = Rndm.Next(1, 18);
            Console.SetCursorPosition(Rx, Ry);
            Console.Write(yem);
        }
    }
    
}

