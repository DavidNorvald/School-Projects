using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_Test
{
    public abstract class Game      //abstract means that the object can never have an instance of itself, it can only be inherited from
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } }      // makes it so that List<Players> will always have an empty list to start with, otherwise it is Null and will throw an error
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }        // value reprisents whatever the "field" is being set as, it is a built-in .NET function
        public abstract void Play();        //abstract methods can only reside inside abstract classes, abstract method contains no implimentation. Inheriting class must impliment the method.

        public virtual void ListPlayers()       // virtual means, this method gets inherited but it has the ability to override it. It has implimentation, but it can be overridden
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
