using System;
using System.Linq;

namespace C_
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            for(int i = n-1; i >= 1; i--)
            {
                n *= i;
            }
            Console.WriteLine("Factorial is: {0}",n);
        }
    }
}