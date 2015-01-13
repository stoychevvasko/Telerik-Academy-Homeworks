// <copyright file="IHand.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace Poker
{
    using System;
    using System.Collections.Generic;

    /// <summary>Allows cards and ToString() functionality for hand-related classes.</summary>
    public interface IHand
    {
        /// <summary>Gets a collection of cards from a hand.</summary>
        IList<ICard> Cards { get; }

        /// <summary>Returns a hand of cards in string form.</summary>
        /// <returns>string value</returns>
        string ToString();
    }
}