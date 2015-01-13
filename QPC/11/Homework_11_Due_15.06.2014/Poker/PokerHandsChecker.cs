// <copyright file="PokerHandsChecker.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace Poker
{
    using System;
    using System.Linq;

    /// <summary>Represents combined functionality with regards to poker hand evaluation.</summary>
    public class PokerHandsChecker : IPokerHandsChecker
    {
        /// <summary>Number of cards in a poker hand.</summary>
        private const int CardsPerHand = 5;

        /// <summary>Determines whether a poker hand is valid or not.</summary>
        /// <param name="hand">a poker hand object</param>
        /// <returns>boolean value</returns>
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != CardsPerHand)
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                for (int k = i + 1; k < hand.Cards.Count; k++)
                {
                    if (hand.Cards[i].ToString() == hand.Cards[k].ToString())
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>Determines whether a poker hand is valid straight flush or not.</summary>
        /// <param name="hand">a poker hand object</param>
        /// <returns>boolean value</returns>
        public bool IsStraightFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("Provided hand is not valid.");
            }

            return this.AreCardsOfSameSuit(hand) && this.IsStraight(hand);
        }

        /// <summary>Determines whether a poker hand is valid four-of-a-kind or not.</summary>
        /// <param name="hand">a poker hand object</param>
        /// <returns>boolean value</returns>
        public bool IsFourOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("Provided hand is not valid.");
            }

            return this.AreCardsOfSameKind(hand, 4);
        }

        /// <summary>Determines whether a poker hand is valid full house or not.</summary>
        /// <param name="hand">a poker hand object</param>
        /// <returns>boolean value</returns>
        public bool IsFullHouse(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("Provided hand is not valid.");
            }

            return this.AreCardsOfSameKind(hand, 3) && this.AreCardsOfSameKind(hand, 2);
        }

        /// <summary>Determines whether a poker hand is valid flush or not.</summary>
        /// <param name="hand">a poker hand object</param>
        /// <returns>boolean value</returns>
        public bool IsFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("Provided hand is not valid.");
            }

            return this.AreCardsOfSameSuit(hand) && this.AreCardsSequential(hand);
        }

        /// <summary>Determines whether a poker hand is valid straight or not.</summary>
        /// <param name="hand">a poker hand object</param>
        /// <returns>boolean value</returns>
        public bool IsStraight(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("Provided hand is not valid.");
            }

            var orderedByCardFace = hand.Cards
                .OrderBy(x => (int)x.Face)
                .ToArray();

            for (int i = 0; i < orderedByCardFace.Count() - 1; i++)
            {
                if ((int)orderedByCardFace[i].Face != (int)orderedByCardFace[i + 1].Face - 1)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>Determines whether a poker hand is valid three-of-a-kind or not.</summary>
        /// <param name="hand">a poker hand object</param>
        /// <returns>boolean value</returns>
        public bool IsThreeOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("Provided hand is not valid.");
            }

            return this.AreCardsOfSameKind(hand, 3) && !this.AreCardsOfSameKind(hand, 2);
        }

        /// <summary>Determines whether a poker hand is valid two-pair or not.</summary>
        /// <param name="hand">a poker hand object</param>
        /// <returns>boolean value</returns>
        public bool IsTwoPair(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("Provided hand is not valid.");
            }

            var groupedByCardFace = hand.Cards
                .GroupBy(x => x.Face)
                .ToDictionary(x => x.Key, y => y.Count())
                .Where(x => x.Value == 2);

            return groupedByCardFace.Count() == 2;
        }

        /// <summary>Determines whether a poker hand is valid one-pair or not.</summary>
        /// <param name="hand">a poker hand object</param>
        /// <returns>boolean value</returns>
        public bool IsOnePair(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("Provided hand is not valid.");
            }

            var groupedByCardFace = hand.Cards
                .GroupBy(x => x.Face)
                .ToDictionary(x => x.Key, y => y.Count())
                .Where(x => x.Value == 2);

            return groupedByCardFace.Count() == 1;
        }

        /// <summary>Determines whether a poker hand is valid high card or not.</summary>
        /// <param name="hand">a poker hand object</param>
        /// <returns>boolean value</returns>
        public bool IsHighCard(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("Provided hand is not valid.");
            }

            if (this.IsStraight(hand) || this.AreCardsOfSameSuit(hand))
            {
                return false;
            }

            var groupedByCardFace = hand.Cards
                .GroupBy(x => x.Face)
                .ToDictionary(x => x.Key, y => y.Count());

            return groupedByCardFace.Count == hand.Cards.Count;
        }

        /// <summary>Compares two hands.</summary>
        /// <param name="firstHand">first hand object</param>
        /// <param name="secondHand">second hand object</param>
        /// <returns>-1 if smaller, 0 if equal, 1 if greater</returns>
        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            if (!this.IsValidHand(firstHand) || !this.IsValidHand(secondHand))
            {
                throw new ArgumentException("Provided hand is not valid.");
            }

            if (this.DuplicateCardsCheck(firstHand, secondHand))
            {
                throw new ArgumentException("Two hands can't contain duplicate cards.");
            }

            var firstHandStrength = this.CheckHandStrength(firstHand);
            var secondHandStrength = this.CheckHandStrength(secondHand);

            if (firstHandStrength > secondHandStrength)
            {
                return 1;
            }
            else if (firstHandStrength < secondHandStrength)
            {
                return -1;
            }
            else
            {
                var firstHandOrderedByCardFace = firstHand.Cards.OrderByDescending(x => (int)x.Face).ToArray();
                var secondHandOrderedByCardFace = secondHand.Cards.OrderByDescending(x => (int)x.Face).ToArray();

                for (int i = 0; i < CardsPerHand; i++)
                {
                    if ((int)firstHandOrderedByCardFace[i].Face > (int)secondHandOrderedByCardFace[i].Face)
                    {
                        return 1;
                    }
                    else if ((int)firstHandOrderedByCardFace[i].Face < (int)secondHandOrderedByCardFace[i].Face)
                    {
                        return -1;
                    }
                }

                return 0;
            }
        }

        /// <summary>Checks if two cards are of the same suit.</summary>
        /// <param name="hand">hand object</param>
        /// <returns>boolean value</returns>
        private bool AreCardsOfSameSuit(IHand hand)
        {
            var suit = hand.Cards[0].Suit;
            return hand.Cards.All(x => x.Suit == suit);
        }

        /// <summary>Checks if two cards are consecutive.</summary>
        /// <param name="hand">hand object</param>
        /// <returns>boolean value</returns>
        private bool AreCardsSequential(IHand hand)
        {
            var groupedByValue = hand.Cards.GroupBy(x => x.Face);
            return groupedByValue.Count() == hand.Cards.Count;
        }

        /// <summary>Checks if two cards are of the same kind.</summary>
        /// <param name="hand">hand object</param>
        /// <param name="sameCardsCount">number of same cards</param>
        /// <returns>boolean value</returns>
        private bool AreCardsOfSameKind(IHand hand, int sameCardsCount)
        {
            var groupedByFace = hand.Cards
                .GroupBy(x => x.Face)
                .ToDictionary(x => x.Key, y => y.Count());

            return groupedByFace.ContainsValue(sameCardsCount);
        }

        /// <summary>Returns the strength of a poker hand.</summary>
        /// <param name="hand">a hand object</param>
        /// <returns>strength integer value</returns>
        private int CheckHandStrength(IHand hand)
        {
            var handStrengthCheckers = new Func<IHand, bool>[]
            {
                    this.IsStraightFlush,
                    this.IsFourOfAKind,
                    this.IsFullHouse,
                    this.IsFlush,
                    this.IsStraight,
                    this.IsThreeOfAKind,
                    this.IsTwoPair,
                    this.IsOnePair,
                    this.IsHighCard
            };

            var length = handStrengthCheckers.Length;

            for (int i = 0; i < length; i++)
            {
                if (handStrengthCheckers[i](hand))
                {
                    return length - i;
                }
            }

            throw new InvalidOperationException("Fatal error! Hand strength can not be correctly determined.");
        }

        /// <summary>Checks if two card hands are exact duplicates.</summary>
        /// <param name="firstHand">first card hand</param>
        /// <param name="secondHand">second card hand</param>
        /// <returns>boolean value</returns>
        private bool DuplicateCardsCheck(IHand firstHand, IHand secondHand)
        {
            for (int i = 0; i < CardsPerHand; i++)
            {
                if (firstHand.Cards[i].ToString() == secondHand.Cards[i].ToString())
                {
                    return true;
                }
            }

            return false;
        }
    }
}