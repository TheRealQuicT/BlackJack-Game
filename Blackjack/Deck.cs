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
        #endregion

        #region Constructors
        public Deck()
        {
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

            CardDeck = new List<Card>();

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
                cards.ShowCard();
            }
        }
        #endregion
    }
}
