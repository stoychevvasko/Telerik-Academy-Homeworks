// <copyright file="ICard.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace Poker
{
    /// <summary>Allows face, suit and ToString() functionality for card-related classes.</summary>
    public interface ICard
    {
        /// <summary>Gets the face of a card.</summary>
        CardFace Face { get; }

        /// <summary>Gets the suit of a card.</summary>
        CardSuit Suit { get; }

        /// <summary>Returns a card in string form.</summary>
        /// <returns>String value</returns>
        string ToString();
    }
}