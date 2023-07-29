using System;
using System.Linq;

namespace C_
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Write anything: ");
            string b = Console.ReadLine();
            char[] a = b.Reverse().ToArray();
            for (int i = 0; i < a.Length; i++) 
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
    }
}