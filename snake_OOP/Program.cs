using System;

namespace snake_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = p1.rand();
            p1.y = p1.rand();
            p1.zv = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = p1.rand();
            p2.y = p1.rand();
            p2.zv = '*';
            p2.Draw();

            Console.ReadLine();
        }
    }
}
