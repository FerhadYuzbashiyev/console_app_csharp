using System;

namespace Lesson
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x, y, temp;
            x = 7;
            y = 2;
            Console.WriteLine("Before swaping: {0}, {1}",x,y);
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After swaping: {0},{1}",x,y);
        }
    }
}