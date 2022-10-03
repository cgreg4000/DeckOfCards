using System;
using System.Collections.Generic;

namespace DeckOfCards
{

    class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            string[] names = new string[]
            {
                "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"
            };
            string[] suits = new string[]
            {
                "Clubs", "Spades", "Hearts", "Diamonds"
            };
            int[] vals = new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13
            };
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < names.Length; j++)
                {
                    cards.Add(new Card(names[j], suits[i], vals[j]));
                }
            }
        }

        public Card Deal()
        {
            Card top = cards[0];
            cards.RemoveAt(0);
            return top;
        }

        public void Reset()
        {
            cards = new List<Card>();
            string[] names = new string[]
            {
                "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"
            };
            string[] suits = new string[]
            {
                "Clubs", "Spades", "Hearts", "Diamonds"
            };
            int[] vals = new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13
            };
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < names.Length; j++)
                {
                    cards.Add(new Card(names[j], suits[i], vals[j]));
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            List<Card> temp = new List<Card>();
            while (cards.Count > 0)
            {
                int randomIndex = rand.Next(0, cards.Count);
                temp.Add(cards[randomIndex]);
                cards.RemoveAt(randomIndex);
            }
            cards = temp;
        }
    }
}