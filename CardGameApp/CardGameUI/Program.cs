using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    public abstract class Deck
    {
        private List<PlayingCard> fullDeck = new List<PlayingCard>();
        private List<PlayingCard> drawPile = new List<PlayingCard>();
        private List<PlayingCard> discardPile = new List<PlayingCard>();
        public void CreateDeck()
        {
            fullDeck.Clear();

            for (int suit = 0; suit < 4; suit++)
            {
                for(int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCard { Suit = (CardSuit)suit, Value = (CardValue)val });
                }
            }
        }

        public virtual void SuffleDeck()
        {
            var rnd = new Random();
            drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();


        }

        public abstract List<PlayingCard> DealCard();

        public virtual PlayingCard RequestCard()
        {
            return null;
        }

    }


    public class PlayingCard
    {
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }
    }

    public enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public enum CardSuit
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }
}
