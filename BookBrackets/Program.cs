using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Import list of books.
            // Pick two random books.

            List<string> books = new List<string>()
            {
                "I believe in a Thing Called Love",
                "If You Come Softly",
                "Opposite of Always",
                "Watch us Rise",
                "Catwoman Soulstealer",
                "Crazy Rich Asians",
                "This Mortal Coil",
                "Becoming",
                "Hazards of Time Travel",
                "Vengeful",
                "Ancient Magus Bride 10",
                "Vitro",
                "Origin",
                "Drama",
                "The Proposal",
                "Tradition",
                "Grimm Lovelies",
                "Give the Dark my Love",
                "Wildcard",
                "MunMun",
                "Shadow and Bone",
                "Spin",
                "Hey, Kiddo",
                "That's not What Happened"
            };

            List<string> winners = new List<string>();

            while(books.Count > 1)
            {
                var book1 = books.First();
                var book2 = books.Last();

                Console.WriteLine("Pick one of these two books:");
                Console.WriteLine($"Enter 1 to select {book1} as the winner.");
                Console.WriteLine($"Enter 2 to select {book2} as the winner.");
                var winner = Console.ReadLine();
                int winnerNum = Convert.ToInt32(winner);

                if (winnerNum == 1)
                {
                    winners.Add(book1);
                }
                else if (winnerNum == 2)
                {
                    winners.Add(book2);
                }

                books.Remove(book1);
                books.Remove(book2);

                if(books.Count == 1)
                {
                    winners.Add(books.First());
                    books.Clear();
                    books.AddRange(winners);
                    winners.Clear();
                }
                else if (books.Count == 0)
                {
                    books.AddRange(winners);
                    winners.Clear();
                    Console.WriteLine("You've completed this round! On to the next one.");
                    Console.WriteLine("\n\n\n");
                }
            }

            var finalWinner = books.First();
            Console.WriteLine($"And the winner is {finalWinner}");
            Console.ReadLine();


            // One advances
            // One doesn't.
            // Continue until winner is chosen.
        }
    }
}
