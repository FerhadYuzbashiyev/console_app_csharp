using System;

namespace C_
{
    internal class Program
    {
        static long Multiple(long n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                if(n % 2 == 0)
                {
                    return n * Multiple(n - 2);
                }
                else
                {
                    n -= 1;
                    return n * Multiple(n - 2);
                }
            }
        }
        public static void Main(string[] args)
        {
            long a;
            Console.Write("Enter a number: ");
            a = long.Parse(Console.ReadLine());
            Console.WriteLine("Multiple of even numbers is: {0}", Multiple(a));
        }
    }
}