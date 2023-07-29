using System;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 24;
            int y = 13;

            int z = (x + y) / 2 + y++ + ++y + 2 * (x-- * 4);
            int w = z++ + (w = y) - --w;
            Console.WriteLine("{0}, {1}, {2}, {3}", x, y, w, z); // 23, 15, 239, 239


            Console.ReadLine();
        }
    }
}
using System;
namespace Lesson
{
    internal class Program {
        public static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = 7;
            int d = 2;
            int e = 4;

            int result = a++ + --b * c - e-- + ++d / a + b-- * c / e;

            Console.WriteLine("Initial values:");
            Console.WriteLine($"a: {a}"); // 4
            Console.WriteLine($"b: {b}"); // 3 
            Console.WriteLine($"c: {c}"); // 7 
            Console.WriteLine($"d: {d}"); // 3
            Console.WriteLine($"e: {e}"); // 3

            Console.WriteLine("Result is " + result); // 36
            

        }
    }
}
using System;
namespace Lesson
{
    internal class Program {
        public static void Main(string[] args)
        {
            int a = 6;
            int b = 5;
            int c = 4;
            int d = 3;
            int e = 2;

            int result = a-- * --b + e++ / c - ++d / a * b++ - --e * c;

            Console.WriteLine("Initial values:");
            Console.WriteLine($"a: {a}"); // 5
            Console.WriteLine($"b: {b}"); // 5 
            Console.WriteLine($"c: {c}"); // 4
            Console.WriteLine($"d: {d}"); // 4
            Console.WriteLine($"e: {e}"); // 2

            Console.WriteLine("Result is " + result); // 16
            

        }
    }
}