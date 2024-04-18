using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdzNaRyby
{
    enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts
    }

    enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
    class Card
    {
        private Suits Suit { get; set; }
        private Values Value { get; set; }

        private Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        private static string[] suits = new string[] { "pik", "trefl", "karo", "kier" };
        private static string[] names = new string[]
        {
                "", "As", "Dwójka", "Trójka", "Czwórka", "Piątka", "Szóstka", "Siódemka", "Ósemka", "Dziewiątka", "Dziesiątka", "Walet", "Dama", "Król"
        };

        public string Name
        {
        get { return names[(int)Value] + " " + suits[(int)Suit]; }
        }

    }

    public partial class Card
    {
        private static string[] names0 = new string[]
        {
            "", "asów", "dwójek", "trójek", "czwórek", "piątek", "szóstek", "siódemek", "ósemek", "dziewiątek", "dziesiątek", "waletów", "dam", "króli" 
        };
        private static string[] names1 = new string[]
        {
            "", "asa", "dwójkę", "trójkę", "czwórke", "piątke", "szóstke", "siódemke", "ósemke", "dziewiątke", "dziesiątke", "waleta", "damę", "króla"
        };
        private static string[] names2AndMore = new string[]
        {
            "", "asy", "dwójki", "trójki", "czwórki", "piątki", "szóstki", "siódemki", "ósemki", "dziewiątki", "dziesiątki", "walety", "damy", "króle"
        };

        public static string Plural(Card.Values value, int count)
        {
            if (count == 0)
                return names0[(int)value];
            if (count == 1)
                return names1[(int)value];
            return names2AndMore[(int)value];
        }
    }
}
