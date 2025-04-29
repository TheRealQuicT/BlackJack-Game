using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Card
    {
        #region Fields
        // Backing Store
        private string _suit;
        private string _value;
        #endregion

        #region Properties
        public string Suit
        {
            get
            {
                return _suit;
            }
            set
            {
                // Ensure not empty.
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Suit cannot be empty.");
                }

                _suit = value.Trim();
            }
        }

        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        #endregion

        #region Constructors
        // Default
        public Card()
        {

        }

        // Greedy
        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Shows the suit and value.
        /// </summary>
        public void ShowCard()
        {
            Console.WriteLine($"{Value} of {Suit}");
        }
        #endregion
    }
}
