// <copyright file="PokerHandsCheckerTests.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;    

    /// <summary>Provides combined poker hand evaluation testing functionality./// </summary>
    [TestClass]
    public class PokerHandsCheckerTests
    {
        /// <summary>Static object for call purposes</summary>
        private static PokerHandsChecker checker;

        /// <summary>Initializes a new PokerHandsChecker object for all tests.</summary>
        /// <param name="textContext">text context parameter</param>
        [ClassInitialize]
        public static void InitializePokerHandsChecker(TestContext textContext)
        {
            checker = new PokerHandsChecker();
        }

        /// <summary>Tests if a null hand is valid.</summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetNullHandToIsValidHandMethod()
        {
            checker.IsValidHand(null);
        }

        /// <summary>Sets the value of one valid hand to another.</summary>
        [TestMethod]
        public void SetValidHandToIsValidHandMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            Assert.IsTrue(checker.IsValidHand(hand));
        }

        /// <summary>Tests duplicate cards with the IsValidHand() method.</summary>
        [TestMethod]
        public void SetDuplicateCardsToIsValidHandMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        /// <summary>Attempt adding more than 5 cards to a hand.</summary>
        [TestMethod]
        public void SetMoreThanAllowedCardsToIsValidHandMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Clubs),
            };

            var hand = new Hand(cards);
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        /// <summary>Tests a valid flush hand.</summary>
        [TestMethod]
        public void SetValidFlushHandToIsFlushMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);
            Assert.IsTrue(checker.IsFlush(hand));
        }

        /// <summary>Tests an invalid flush hand.</summary>
        [TestMethod]
        public void SetInvalidFlushHandToIsFlushMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);
            Assert.IsFalse(checker.IsFlush(hand));
        }

        /// <summary>Tests a valid four-of-a-kind hand.</summary>
        [TestMethod]
        public void SetValidFourOfAKindInIsFourOfAKindMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);
            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        /// <summary>Tests an invalid four-of-a-kind hand.</summary>
        [TestMethod]
        public void SetInvalidFourOfAKindInIsFourOfAKindMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);
            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

        /// <summary>Tests a valid full house hand.</summary>
        [TestMethod]
        public void SetValidFullHouseInIsFullHouseMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);
            Assert.IsTrue(checker.IsFullHouse(hand));
        }

        /// <summary>Tests an invalid full house hand.</summary>
        [TestMethod]
        public void SetInvalidFullHouseInIsFullHouseMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades)
            };

            var hand = new Hand(cards);
            Assert.IsFalse(checker.IsFullHouse(hand));
        }

        /// <summary>Tests a valid straight hand.</summary>
        [TestMethod]
        public void SetValidStraightToIsStraightMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades)
            };

            var hand = new Hand(cards);
            Assert.IsTrue(checker.IsStraight(hand));
        }

        /// <summary>Tests an invalid straight hand.</summary>
        [TestMethod]
        public void SetInvalidStraightToIsStraightMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades)
            };

            var hand = new Hand(cards);
            Assert.IsFalse(checker.IsStraight(hand));
        }

        /// <summary>Tests a valid straight flush hand.</summary>
        [TestMethod]
        public void SetValidStraightFlushToIsStraightFlushMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades)
            };

            var hand = new Hand(cards);
            Assert.IsTrue(checker.IsStraightFlush(hand));
        }

        /// <summary>Tests an invalid straight flush hand.</summary>
        [TestMethod]
        public void SetInvalidStraightFlushToIsStraightFlushMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades)
            };

            var hand = new Hand(cards);
            Assert.IsFalse(checker.IsStraightFlush(hand));
        }

        /// <summary>Tests a valid three-of-a-kind hand.</summary>
        [TestMethod]
        public void SetValidThreeOfKindToIsThreeOfKindMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades)
            };

            var hand = new Hand(cards);
            Assert.IsTrue(checker.IsThreeOfAKind(hand));
        }

        /// <summary>Tests an invalid three-of-a-kind hand.</summary>
        [TestMethod]
        public void SetInvalidThreeOfKindToIsThreeOfKindMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades)
            };

            var hand = new Hand(cards);
            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }

        /// <summary>Tests a valid two pairs hand.</summary>
        [TestMethod]
        public void SetValidTwoPairsToIsTwoPairMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Spades)
            };

            var hand = new Hand(cards);
            Assert.IsTrue(checker.IsTwoPair(hand));
        }

        /// <summary>Tests an invalid two pairs hand.</summary>
        [TestMethod]
        public void SetInvalidTwoPairsToIsTwoPairMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);
            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        /// <summary>Tests a valid one-pair hand.</summary>
        [TestMethod]
        public void SetValidPairToIsOnePairMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);
            Assert.IsTrue(checker.IsOnePair(hand));
        }

        /// <summary>Tests an invalid one-pair hand.</summary>
        [TestMethod]
        public void SetInvalidPairToIsOnePairMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);
            Assert.IsFalse(checker.IsOnePair(hand));
        }

        /// <summary>Tests a valid high card hand.</summary>
        [TestMethod]
        public void SetValidHandToIsHighHandMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds)
            };

            var hand = new Hand(cards);
            Assert.IsTrue(checker.IsHighCard(hand));
        }

        /// <summary>Tests an invalid high card hand.</summary>
        [TestMethod]
        public void SetInvalidHandToIsHighHandMethod()
        {
            var cards = new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Hearts)
            };

            var hand = new Hand(cards);
            Assert.IsFalse(checker.IsHighCard(hand));
        }

        /// <summary>Tests comparison of duplicate cards.</summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetHandsWithDuplicateCardsInCompareHandsMethod()
        {
            var firstHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Hearts)
            });

            var secondHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds)
            });

            checker.CompareHands(firstHand, secondHand);
        }

        /// <summary>Compare a royal flush vs a straight flush.</summary>
        [TestMethod]
        public void CompareHandsRoyalFlushVsStraightFlushTest()
        {
            var royalFlush = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades)
            });

            var straightFlush = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Diamonds)
            });

            Assert.IsTrue(checker.CompareHands(royalFlush, straightFlush) == 1);
        }

        /// <summary>Compares a four-of-a-kind hand with a full-house one.</summary>
        [TestMethod]
        public void CompareHandsFourOfAKindVsFullHouseTest()
        {
            var fourSevens = new Hand(new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades)
            });

            var fullHouse = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            });

            Assert.IsTrue(checker.CompareHands(fourSevens, fullHouse) == 1);
        }

        /// <summary>Compares a high-card hand with king vs one with jack.</summary>
        [TestMethod]
        public void CompareHandsHighCardWithKingVsHighCardWithJackTest()
        {
            var highCardWithJack = new Hand(new List<ICard>()
            {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds)
            });

            var highCardWithKing = new Hand(new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Spades)
            });

            Assert.IsTrue(checker.CompareHands(highCardWithJack, highCardWithKing) == -1);
        }

        /// <summary>Compares two equal pairs hands.</summary>
        [TestMethod]
        public void CompareHandsTwoEqualPairsTest()
        {
            var firstHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds)
            });

            var secondHand = new Hand(new List<ICard>()
            {
                 new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Hearts)
            });

            Assert.IsTrue(checker.CompareHands(firstHand, secondHand) == 0);
        }

        /// <summary>Compares two-pair hands.</summary>
        [TestMethod]
        public void CompareHandsTwoPairsTest()
        {
            var firstHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds)
            });

            var secondHand = new Hand(new List<ICard>()
            {
                 new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Hearts)
            });

            Assert.IsTrue(checker.CompareHands(firstHand, secondHand) == -1);
        }

        /// <summary>Compares two straight hands.</summary>
        [TestMethod]
        public void CompareHandsStraightVsStraightTest()
        {
            var firstHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds)
            });

            var secondHand = new Hand(new List<ICard>()
            {
                 new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Hearts)
            });

            Assert.IsTrue(checker.CompareHands(firstHand, secondHand) == -1);
        }

        /// <summary>Compares one-pair hand with queen against one-pair hand with ten.</summary>
        [TestMethod]
        public void CompareHandsOnePairWithQueenVsOnePairWithTenTest()
        {
            var firstHand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds)
            });

            var secondHand = new Hand(new List<ICard>()
            {
                 new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Hearts)
            });

            Assert.IsTrue(checker.CompareHands(firstHand, secondHand) == 1);
        }
    }
}