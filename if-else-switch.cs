using System;
using System.Globalization;

namespace Lesson
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a;
            Console.Write("Enter your number: ");
            a = int.Parse(Console.ReadLine());
            if(a > 0)
            {
                Console.WriteLine("{0} is positive", a);
            }
            else if(a < 0)
            {
                Console.WriteLine("{0} is negative", a);
            }
            else
            {
                Console.WriteLine("{0} is zero", a);
            }
            int day = 0;
            Console.WriteLine("Enter a number [1-7]");
            day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("It's Monday");
                    break;
                case 2:
                    Console.WriteLine("It's Tuesday");
                    break;
                case 3:
                    Console.WriteLine("It's Wednesday");
                    break;
                case 4:
                    Console.WriteLine("It's Thursday");
                    break;
                case 5:
                    Console.WriteLine("It's Friday");
                    break;
                case 6:
                    Console.WriteLine("It's Saturday");
                    break;
                case 7:
                    Console.WriteLine("It's Sunday");
                    break;
                default:
                    Console.WriteLine("Error! Wrong weekday.");
                    break;
            }
        }
    }
}