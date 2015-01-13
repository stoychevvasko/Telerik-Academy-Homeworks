// <copyright file="HandToStringTests.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;    

    /// <summary>Provides ToString() testing functionality for the Hand class.</summary>
    [TestClass]
    public class HandToStringTests
    {
        /// <summary>Tests ToString() on an empty card hand.</summary>
        [TestMethod]
        public void EmptyHandTest()
        {
            var hand = new Hand(new List<ICard>());
            var expectedResult = string.Empty;

            Assert.AreEqual(expectedResult, hand.ToString());
        }

        /// <summary>Tests ToString() on a hand with a single Jack of diamonds card.</summary>
        [TestMethod]
        public void JackOfDiamondsHandTest()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);
            var expectedResult = "J♦";

            Assert.AreEqual(expectedResult, hand.ToString());
        }

        /// <summary>Tests ToString() on a hand containing a two of clubs and a five of hearts.</summary>
        [TestMethod]
        public void TwoOfClubsAndFiveOfHeartsHandTest()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts)
            };

            var hand = new Hand(cards);
            var expectedResult = "2♣ 5♥";

            Assert.AreEqual(expectedResult, hand.ToString());
        }

        /// <summary>Tests ToString() on a royal flush of spades hand.</summary>
        [TestMethod]
        public void RoyalFlushOfSpadesHandTest()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades)
            };

            var hand = new Hand(cards);
            var expectedResult = "A♠ K♠ Q♠ J♠ 10♠";

            Assert.AreEqual(expectedResult, hand.ToString());
        }
    }
}