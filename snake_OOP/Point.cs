using System;
using System.Collections.Generic;
using System.Text;

namespace snake_OOP
{
    class Point
    {
        public int x;
        public int y;
        public char zv;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(zv);
        }

        public int rand()
        {
            int x;
            Random rnd = new Random();
            x = rnd.Next(0, 20);
            return x;
        }
    }
}
