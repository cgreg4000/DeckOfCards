using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Player
    {
        public string name;
        public List<Card> hand;

        public Player(string n)
        {
            name = n;
            hand = new List<Card>();
        }

        public Card Draw(Deck deck)
        {
            Card draw = deck.cards[0];
            hand.Add(draw);
            deck.cards.RemoveAt(0);
            return draw;
        }

        public Card Discard(int index)
        {
            if (index >= 0 && index < hand.Count)
            {
                Card discard = hand[index];
                hand.RemoveAt(index);
                return discard;
            }
            return null;
        }
    }
}