using System;
namespace abc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float F, C;
            Console.Write("Enter the temperature in Celsius: ");
            C = int.Parse(Console.ReadLine());
            F = C * (9 / 5) + 32;
            Console.Write("The temperature in Fahrenheit is: " + F);
            Console.ReadLine();
        }
    }
}