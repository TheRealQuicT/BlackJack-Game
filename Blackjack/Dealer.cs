using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Dealer
    {
        #region Fields
        private List<Card> _dealersCards;
        private int _cardValues;
        #endregion

        #region Properties
        public List<Card> DealersCards
        {
            get
            {
                return _dealersCards;
            }
            set
            {
                _dealersCards = value;
            }
        }

        public int CardValues
        {
            get
            {
                return _cardValues;
            }
            set
            {
                _cardValues = value;
            }
        }
        #endregion

        #region Constructors
        // Default
        public Dealer()
        {
            // Add logic to add card and give card to discard pile
            // Add logic to add card value to total card values for dealer
        }
        #endregion
    }
}
