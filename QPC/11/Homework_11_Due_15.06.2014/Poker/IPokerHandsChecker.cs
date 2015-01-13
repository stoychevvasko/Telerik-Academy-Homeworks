// <copyright file="IPokerHandsChecker.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace Poker
{
    /// <summary>Interface for checking poker hands as defined in http://en.wikipedia.org/wiki/List_of_poker_hands. </summary>
    public interface IPokerHandsChecker
    {
        /// <summary>Determines if a hand is valid or not.</summary>
        /// <param name="hand">a hand object</param>
        /// <returns>boolean value</returns>
        bool IsValidHand(IHand hand);

        /// <summary>Determines if a hand is a straight flush or not.</summary>
        /// <param name="hand">a hand object</param>
        /// <returns>boolean value</returns>
        bool IsStraightFlush(IHand hand);

        /// <summary>Determines if a hand is a four of a kind or not.</summary>
        /// <param name="hand">a hand object</param>
        /// <returns>boolean value</returns>
        bool IsFourOfAKind(IHand hand);

        /// <summary>Determines if a hand is a full house or not.</summary>
        /// <param name="hand">a hand object</param>
        /// <returns>boolean value</returns>
        bool IsFullHouse(IHand hand);

        /// <summary>Determines if a hand is a flush or not.</summary>
        /// <param name="hand">a hand object</param>
        /// <returns>boolean value</returns>
        bool IsFlush(IHand hand);

        /// <summary>Determines if a hand is a straight or not.</summary>
        /// <param name="hand">a hand object</param>
        /// <returns>boolean value</returns>
        bool IsStraight(IHand hand);

        /// <summary>Determines if a hand is a three of a kind or not.</summary>
        /// <param name="hand">a hand object</param>
        /// <returns>boolean value</returns>
        bool IsThreeOfAKind(IHand hand);

        /// <summary>Determines if a hand is a two-pair or not.</summary>
        /// <param name="hand">a hand object</param>
        /// <returns>boolean value</returns>
        bool IsTwoPair(IHand hand);

        /// <summary>Determines if a hand is a one-pair or not.</summary>
        /// <param name="hand">a hand object</param>
        /// <returns>boolean value</returns>
        bool IsOnePair(IHand hand);

        /// <summary>Determines if a hand is a high card or not.</summary>
        /// <param name="hand">a hand object</param>
        /// <returns>boolean value</returns>
        bool IsHighCard(IHand hand);

        /// <summary>Compares two hands.</summary>
        /// <param name="firstHand">first hand object</param>
        /// <param name="secondHand">second hand object</param>
        /// <returns>-1 if smaller, 0 if equal, 1 if greater</returns>
        int CompareHands(IHand firstHand, IHand secondHand);
    }
}