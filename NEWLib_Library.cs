using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace Test
{
    internal class LibraryItem : Display
    {
        protected string[] allBooks = new string[]
        {
            "Amelia Adventureheart",
            "Chronicles of the Eternity Key",
            "Lost in the Labyrinth of Dreams",
            "The Enchanted Alchemist's Apprentice",
            "Echoes of Forgotten Realms",
            "Serpents of the Celestial Isles",
            "The Secret Garden of Time",
            "Tales from the Quantum Realm",
            "Wandering through Wonders: A Traveler's Odyssey"
        };
        protected string[] allAuthors = new string[]
        {
            "Isabella Nightshade",
            "Aiden Everbright",
            "Evelyn Mystere",
            "Magnus Arcanum",
            "Seraphina Shadowdancer",
            "Lucius Stormrider",
            "Elara Moonshadow",
            "Dr. Orion Quantum",
            "Amelia Adventureheart"
        };
        protected string[] PatronsNames = new string[]
        {
            "Emily",
            "Benjamin",
            "Sophia"
        };
        protected long[] ISBN = new long[]
        {
            9780451526342,
            9780141439563,
            9780061120084,
            9780670020553,
            9780385341004,
            9780307743657,
            9780553280360,
            9780446310789,
            9780064407663
        };
        protected enum BookStatus
        {
            Available,
            Checked_Out,
            Lost
        }
        protected void ShowPatronsInfo()
        {
            for (int i = 0; i < PatronsNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {PatronsNames[i]}");
            }
            Console.WriteLine();
        }
        protected void ShowBooksInfo()
        {
            Console.WriteLine();
            for (int i = 0; i < allBooks.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {allBooks[i]}");
            }
            Console.WriteLine();
        }
    }
}