// <copyright file="Card.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace Poker
{
    using System;
    using System.Text;

    /// <summary>Represents a card.</summary>
    public class Card : ICard
    {
        /// <summary>Initializes a new instance of the <see cref="Card"/> class.</summary>
        /// <param name="face">card face</param>
        /// <param name="suit">card suit</param>
        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        /// <summary>Gets the face of a card.</summary>
        public CardFace Face { get; private set; }

        /// <summary>Gets the suit of a card.</summary>
        public CardSuit Suit { get; private set; }
                
        /// <summary>Returns a card in string form.</summary>
        /// <returns>string value</returns>
        public override string ToString()
        {
            var output = new StringBuilder();

            if ((int)this.Face <= 10)
            {
                output.Append((int)this.Face);
            }
            else
            {
                output.Append(this.Face.ToString()[0]);
            }

            switch ((int)this.Suit)
            {
                case 1: output.Append("♣"); 
                    break;
                case 2: output.Append("♦"); 
                    break;
                case 3: output.Append("♥"); 
                    break;
                case 4: output.Append("♠"); 
                    break;
            }

            return output.ToString();
        }
    }
}