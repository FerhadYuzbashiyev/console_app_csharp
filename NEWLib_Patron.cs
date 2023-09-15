using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Test
{
    internal class Patron : LibraryItem
    {
        // private string[] patronsNames;
        private string[] contactInfo = new string[3];
        private string[][] borrowedBooks = new string[3][];
        public string[] contactInfoPATRON = new string[3];
        public string[][] borrowedBooksPATRON = new string[3][];
        /*public void AssignmentForPatron()
        {
            for (int i = 0; i < this.borrowedBooks.GetLength(0); i++)
            {
                for (int j = 0; j < this.borrowedBooks[i].Length; j++)
                {
                    this.borrowedBooksPATRON[i] = new string[this.borrowedBooks[i].Length];
                }
            }
            for (int i = 0; i < this.borrowedBooks.GetLength(0) && i < this.borrowedBooksPATRON.GetLength(0); i++)
            {
                for (int j = 0; j < this.borrowedBooks[i].Length && j < this.borrowedBooksPATRON[i].Length; j++)
                {
                    this.borrowedBooksPATRON[i][j] = this.borrowedBooks[i][j];
                }
            }
            for (int i = 0; i < this.borrowedBooks.GetLength(0); i++)
            {
                for (int j = 0; j < this.borrowedBooks[i].Length; j++)
                {
                    Console.WriteLine(this.borrowedBooksPATRON[i][j]);
                }
                Console.WriteLine();
            }
        }*/
        public void SetFullPatronInfo()
        {
            int count;
            int choosePatron;
            int[] chooseBook;
            string contactInfo;
            string[] wantedBooks;
            bool flag = true;
            ShowPatronsInfo();
            Console.Write("Choose a patron: ");
            choosePatron = int.Parse(Console.ReadLine());
            if (choosePatron < 1 || choosePatron > 3)
                {
                Console.WriteLine("You have to choose between 1 and 3!");
                SetFullPatronInfo();
            }
            Console.Write($"Input a contact info for {PatronsNames[choosePatron - 1]}: ");
            contactInfo = Console.ReadLine();
            ShowBooksInfo();
            Console.Write("Choose a number of books: ");                
            count = int.Parse(Console.ReadLine());
            if (count < 1 || count > 9)
                {
                Console.WriteLine("Library policy: You can't take more than 9 books in 1 time!");
                SetFullPatronInfo();
            }
            chooseBook = new int[count]; // Assigning new length to My Books indexes
            Console.Write("Input the books: ");
            for (int i = 0; i < chooseBook.Length; i++)
            {
                chooseBook[i] = int.Parse(Console.ReadLine());
                if (chooseBook[i] < 1 || chooseBook[i] > 9)
                {
                    Console.WriteLine("Choose a number between 1 and 9!");
                    SetFullPatronInfo();
                }
            }
            Console.WriteLine();
            Array.Sort(chooseBook);
            chooseBook = chooseBook.Distinct().ToArray();
            count = chooseBook.Length;
            wantedBooks = new string[count]; // Assigning new length to My Books
            this.borrowedBooks[choosePatron - 1] = new string[count]; // Assigning new length to My Books[]
            // Wanna learn all lengths ------------------------------------
            /*Console.WriteLine("chooseBook: ");
            foreach (var item in chooseBook)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(chooseBook.Length);
            Console.WriteLine();
            Console.WriteLine("borrowedBooks: ");
            foreach (var item in borrowedBooks)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine(borrowedBooks.Length);
                        Console.WriteLine();
                        Console.WriteLine("this.borrowedBooks: ");
                        foreach (var item in this.borrowedBooks[choosePatron - 1])
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine(this.borrowedBooks[choosePatron - 1].Length);
                        Console.WriteLine();*/
            // ----------------------------------------------------

            //Assignment to this.
            for (int i = 0; i < chooseBook.Length; i++)
            {
                // Console.WriteLine(allBooks[chooseBook[i] - 1]; Shows chosen books
                this.borrowedBooks[choosePatron - 1][i] = allBooks[chooseBook[i] - 1];
            }
            if (contactInfo == "")
            {
                this.contactInfo[choosePatron - 1] = "No data";
            }
            else
            {
                this.contactInfo[choosePatron - 1] = contactInfo;
            }
            //Assignment is over
        }
        public override void ShowFullInfo()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Name: {PatronsNames[i]}\n");
                Console.Write($"Contact Info: {this.contactInfo[i]}\n");
                Console.Write("Borrowed Books: ");
                for (int j = 0; j < borrowedBooks[i].Length; j++)
                {
                    Console.Write(borrowedBooks[i][j]);
                    if (borrowedBooks[i][j] != borrowedBooks[i][borrowedBooks[i].Length - 1])
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
        }
    }
}