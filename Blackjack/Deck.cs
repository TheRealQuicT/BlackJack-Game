using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Deck
    {
        #region Fields
        private List<Card> _cardDeck;
        private List<Card> _discardPile;
        private Card _playedCards;
        #endregion

        #region Properties
        public List<Card> CardDeck
        {
            get
            {
                return _cardDeck;
            }
            set
            {
                _cardDeck = value;
            }
        }

        public Card PlayedCard
        {
            get
            {
                return _playedCards;
            }
        }

        public List<Card> DiscardPile
        {
            get
            {
                return _discardPile;
            }
            set
            {
                _discardPile = value;
            }
        }
        #endregion

        #region Constructors
        // Default
        public Deck()
        {
            CardDeck = new List<Card>();
            DiscardPile = new List<Card>();

            List<string> suit = new List<string>();
            List<string> value = new List<string>();

            suit.Add("Hearts");
            suit.Add("Diamonds");
            suit.Add("Clubs");
            suit.Add("Spades");

            value.Add("Ace");
            for (int i = 2; i < 11; i++)
            {
                value.Add(i.ToString());
            }
            value.Add("Jack");
            value.Add("Queen");
            value.Add("King");

            foreach (string i in suit)
            {
                foreach (string j in value)
                {
                    Card newCard = new Card(i, j);
                    CardDeck.Add(newCard);
                }
            }
        }
        #endregion

        #region Methods
        public void ShowCards()
        {
            foreach (Card cards in CardDeck)
            {
                Console.WriteLine(cards.ShowCard());
            }
        }

        public void RemoveCard()
        {
            CardDeck.Remove(PlayedCard);
            DiscardPile.Add(PlayedCard);
        }

        public void Shuffle()
        {
            // Add logic to randomize cards in deck.
        }

        public List<Card> EndOfDeck()
        {
            // Add Logic to add back the cards from discard pile and shuffle the deck again.
            return new List<Card>();
        }
        #endregion
    }
}
