namespace SnakeGame
{
    class Node
    {
        private int x;
        private int y;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public Node(int pX, int pY)
        {
            x = pX;
            y = pY;
        }
        public void Kenar(int kX, int kY)
        {
            if (kX > 78)
            {
                x = 1;
            }
            if (kX < 1)
            {
                x = 78;
            }
            if (kY < 1)
            {
                y = 21;
            }
            if (kY > 21)
            {
                y = 1;
            }
        }
    }
}