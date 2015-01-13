// <copyright file="Hand.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>Represents a poker hand</summary>
    public class Hand : IHand
    {
        /// <summary>Initializes a new instance of the <see cref="Hand"/> class.</summary>
        /// <param name="cards">a collection of cards</param>
        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }
        
        /// <summary>Gets cards from a hand.</summary>
        public IList<ICard> Cards { get; private set; }
        
        /// <summary>Returns a hand of cards in string form.</summary>
        /// <returns>string value</returns>
        public override string ToString()
        {
            var output = new StringBuilder();

            foreach (var card in this.Cards)
            {
                output.AppendFormat("{0} ", card);
            }

            return output.ToString().Trim();
        }
    }
}