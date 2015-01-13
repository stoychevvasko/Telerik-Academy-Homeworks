// <copyright file="CardToStringTests.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>Provides card ToString() testing functionality.</summary>
    [TestClass]
    public class CardToStringTests
    {
        /// <summary>Tests ToString() on a ten of spades card.</summary>
        [TestMethod]
        public void TenOfSpadesToStringTest()
        {
            var tenOfSpades = new Card(CardFace.Ten, CardSuit.Spades);
            string expectedResult = "10♠";

            Assert.AreEqual(expectedResult, tenOfSpades.ToString());
        }
        
        /// <summary>Tests ToString() on a king of diamonds card.</summary>
        [TestMethod]
        public void KingOfDiamondsToStringTest()
        {
            var kingOfDiamonds = new Card(CardFace.King, CardSuit.Diamonds);
            string expectedResult = "K♦";

            Assert.AreEqual(expectedResult, kingOfDiamonds.ToString());
        }

        /// <summary>Tests ToString() on a queen of clubs card.</summary>
        [TestMethod]
        public void QueenOfClubsToStringTest()
        {
            var queenOfClubs = new Card(CardFace.Queen, CardSuit.Clubs);
            string expectedResult = "Q♣";

            Assert.AreEqual(expectedResult, queenOfClubs.ToString());
        }

        /// <summary>Tests ToString() on a four of hearts card.</summary>
        [TestMethod]
        public void FourOfHeartsToStringTest()
        {
            var fourOfHearts = new Card(CardFace.Four, CardSuit.Hearts);
            string expectedResult = "4♥";

            Assert.AreEqual(expectedResult, fourOfHearts.ToString());
        }
    }
}