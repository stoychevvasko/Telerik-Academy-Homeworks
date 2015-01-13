// <copyright file="PokerExample.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>my name is Legion for we are many</author>

namespace Poker
{
    using System;
    using System.Collections.Generic;

    /// <summary>Contains Main() method.</summary>
    public class PokerExample
    {
        /// <summary>Provides main executable logic.</summary>
        public static void Main()
        {
            ICard card = new Card(CardFace.Ace, CardSuit.Clubs);
            Console.WriteLine(card);

            IHand hand = new Hand(new List<ICard>() 
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            Console.WriteLine(hand);

            IPokerHandsChecker checker = new PokerHandsChecker();
            Console.WriteLine(checker.IsValidHand(hand));
            Console.WriteLine(checker.IsOnePair(hand));
            Console.WriteLine(checker.IsTwoPair(hand));
            Console.WriteLine(checker.IsFlush(hand));
        }
    }
}