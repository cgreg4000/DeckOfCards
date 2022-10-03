using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Card testCard = new Card("4", "Clubs", 4);
            // testCard.Print();

            Deck deck1 = new Deck();
            // foreach (Card card in deck1.cards)
            // {
            //     card.Print();
            // }
            // Console.WriteLine(deck1.cards.Count);

            deck1.Deal();
            deck1.Deal();
            deck1.Deal();
            // foreach (Card card in deck1.cards)
            // {
            //     card.Print();
            // }
            // Console.WriteLine(deck1.cards.Count);

            deck1.Shuffle();
            // foreach (Card card in deck1.cards)
            // {
            //     card.Print();
            // }
            // Console.WriteLine(deck1.cards.Count);

            deck1.Reset();
            // foreach (Card card in deck1.cards)
            // {
            //     card.Print();
            // }
            // Console.WriteLine(deck1.cards.Count);

            deck1.Shuffle();
            // foreach (Card card in deck1.cards)
            // {
            //     card.Print();
            // }
            // Console.WriteLine(deck1.cards.Count);

            Player player1 = new Player("Player1");
            Console.WriteLine(player1.name);

            player1.Draw(deck1);
            player1.Draw(deck1);
            player1.Draw(deck1);
            foreach (Card card in player1.hand)
            {
                card.Print();
            }
            // Console.WriteLine(deck1.cards.Count);
            // foreach (Card card in deck1.cards)
            // {
            //     card.Print();
            // }
            // Console.WriteLine(deck1.cards.Count);

            player1.Discard(1);
            foreach (Card card in player1.hand)
            {
                card.Print();
            }
            player1.Discard(0);
            player1.Discard(0);
            player1.Discard(0);
            foreach (Card card in player1.hand)
            {
                card.Print();
            }
            // foreach (Card card in player1.hand)
            // {
            //     card.Print();
            // }
        }
    }
}
