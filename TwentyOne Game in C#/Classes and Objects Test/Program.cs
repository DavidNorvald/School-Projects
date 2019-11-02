using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_Test
{
    class Program       // Every data type in C# is either a Reference type or a Value type, these 2 types have different behaviors
    {
        static void Main(string[] args)     // ctrl shift B, builds the program without compling
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")     // "||" are "or" symbols, "yes or yeah or y or ya"
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");

            }
            Console.WriteLine("Feel free to look around the casino. bye for now.");
            Console.Read();



            //Deck deck = new Deck();

            //int count = deck.Cards.Count(x => x.Face == Face.Ace);         

            //int count = 0;        // a way to find out how many "Aces" are left in a deck, it can be tedious to write without a Lambda Function
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face.Ace)
            //    {
            //        count++;
            //    }
            //}

            //int count = deck.Cards.Count();         // Count() is a Lambda function
            //deck.Shuffle(3);       // able to add how many times you want deck to shuffle by adding , number
            //deck = Shuffle(deck: deck, times: 3);         // using named value using ":"

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();

            //int number = 5;       // a struct is the same as a class, except it is a value type, an "int" is a "struct"       // a class is a reference type, a struct is a value type that cannot inherit
            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;      // by changing "Card" class to struct, card1 is now it's own separate instance, card2 does not influence card1 anymore
            //card2.Face = Face.King;
            //Console.WriteLine(card1.Face);

            //Card card = new Card();
            //card.Suit = Suit.Clubs;         // enum mandates that only the following suits can be selected from the drop down intelisense list
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);       // comes up with the value of 1, because the index of "Diamonds" is 1, not 0, in the index of 4 items(0-3)

            //Game game = new TwentyOneGame();        //Operator overloading using + and - keys to add or remove players automatically, jumps into polymorphism as well, as the operators can be used in other "Games" besides TwentyOne
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game = game + player;       // Shorthand is: game += player;
            //game = game - player;       // Shorthand is: game -= player;

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //Console.ReadLine();

            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();
            //games.Add(game);

            //Game game = new TwentyOneGame();        // simplest form of polymorphism, TwentyOneGame inherates from the Game class

            //Game game = new Game();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //Console.ReadLine();

            //DaysOfTheWeek day = DaysOfTheWeek.Monday;       // enum's limit the possible values you can receive from a user     // helps limit errors from users
            //ConsoleColor color = ConsoleColor." color you can choose from in the list "       // built in enum for developers, only limits you to choosing prebuilt colors



            // ############### LAMBDA EXPRESSIONS #################
            //    VERY HARD TO DEBUG, YOU CANNOT STEP THROUGH YOUR CODE TO DEBUG WITH A FOREACH LOOP......

            //List<int> numberList = new List<int>() { 1, 2, 3, 457, 856, 1566, 23 };
            //int sum = numberList.Where(x => x > 20).Sum();          // chaining lambda functions together, all items above 20 added together for this method
            //int sum = numberList.Min();         // would be 1
            //int sum = numberList.Max();       //would be 1566
            //int sum = numberList.Sum(x => x + 5);       // does additional math on Sum function, this one adds 5 to each item in the list, so 35 extra
            //Console.WriteLine(sum);
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //foreach(Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            Console.ReadLine();
        }


        //public enum DaysOfTheWeek
        //{
        //    Monday,
        //    Tuesday,
        //    wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
