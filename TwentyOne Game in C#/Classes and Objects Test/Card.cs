using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_Test
{
    public struct Card
    {       // Object class, this is where you add things like the object's state to it. 
        //public Card()        // constructor
        //{

        //}

        public Suit Suit { get; set; }        // data type string, you can "get" this item and "set" this item. object is set to public so it can be used in other programs.
        public Face Face { get; set; }        // set as String due to having Aces, Kings, Queens, and Jacks for 21 game

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }

    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jacks,
            Queen,
            King,
            Ace
    }
}
