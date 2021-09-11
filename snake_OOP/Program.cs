using System;

namespace snake_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2;
            char zv = '*';

            x1 = rand();
            y1 = rand();

            Draw(x1, y1, zv);

            x2 = rand();
            y2 = rand();
            Draw(x2, y2, zv);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char zv)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(zv);
        }

        static int rand()
        {
            int x;
            Random rnd = new Random();
            x = rnd.Next(0, 20);
            return x;
        }
    }
}
