using System;

namespace Hello
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            float first_sub, second_sub, third_sub;
            float avg;
            Console.Write("Enter the score for subject 1: ");
            first_sub = int.Parse(Console.ReadLine());
            Console.Write("Enter the score for subject 2: ");
            second_sub = int.Parse(Console.ReadLine());
            Console.Write("Enter the score for subject 3: ");
            third_sub = int.Parse(Console.ReadLine());
            avg = (first_sub + second_sub + third_sub) / 3;
            Console.WriteLine("The average grade is: " + avg);
            Console.ReadLine();
            }
        }
    }