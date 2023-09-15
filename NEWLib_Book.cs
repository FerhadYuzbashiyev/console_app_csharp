using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Test
{
    internal class Book : Patron
    {
        
        private string[] contactInfoPatronBook = new string[3];
        public override void ShowFullInfo()
        {
            int bookCount = 0;
            int[] showBooks;
            ShowBooksInfo();
            Console.WriteLine("Choose a book count: ");
            bookCount = int.Parse(Console.ReadLine());
            showBooks = new int[bookCount];
            Console.WriteLine("Choose books ID to get their information: ");
            for (int i = 0; i < showBooks.Length; i++)
            {
                showBooks[i] = int.Parse(Console.ReadLine());
                if (showBooks[i] < 1 || showBooks[i] > 9)
                {
                    Console.WriteLine("Choose between 1 and 9!");
                    ShowFullInfo();
                }
            }
            Array.Sort(showBooks);
            showBooks = showBooks.Distinct().ToArray();
            bookCount = showBooks.Length;
            Console.WriteLine();
            for (int i = 0; i < showBooks.Length; i++)
            {
                Console.Write($"{i + 1}) ");
                Console.WriteLine($"Title: {allBooks[showBooks[i] - 1]}");
                Console.WriteLine($"Author: {allAuthors[showBooks[i] - 1]}");
                Console.WriteLine($"ISBN: {ISBN[showBooks[i] - 1]}");
                Console.WriteLine();
            }
            //Console.WriteLine(allBooks[showBooks[1] - 1]);
        }
    }
}