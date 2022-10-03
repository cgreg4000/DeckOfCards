using System;

namespace DeckOfCards
{
    class Card
    {
        public string name;
        public string suit;
        public int val;

        public Card(string n, string s, int v)
        {
            name = n;
            suit = s;
            val = v;
        }

        public void Print()
        {
            Console.WriteLine($"{this.name} of {this.suit} ({this.val})");
        }
    }
}