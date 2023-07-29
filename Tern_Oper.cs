using System;
using System.Linq;

namespace C_
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double score;
            Console.Write("Write your score: ");
            score = double.Parse(Console.ReadLine());
            string letter_grade;
            letter_grade = (score >= 90 && score <= 100) ? "A" : ((score >= 80 && score <= 89.99) ? "B" : ((score >= 70 && score <= 79.99) ? "C" : ((score >= 60 && score <= 69.99) ? "D" : ((score >= 0 && score <= 59.99) ? "F" : "undefined"))));
            Console.WriteLine("Your letter grade is: {0}", letter_grade);
        }
    }
}