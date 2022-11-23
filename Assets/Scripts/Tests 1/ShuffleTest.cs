using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System;

public class ShuffleTest
{
    [Test]
    public void ShouldShuffleAnIntDeckInPlace()
    {
        int[] deck = new int[] { 1,2,3,4,5,6 };

        Shuffle.shuffleDeck(deck);
        
        Assert.That(deck, Is.Not.Null);
        Assert.That(deck, Is.EquivalentTo(new int[] { 1,2,3,4,5,6 })); // must have same contents in any order
        Assert.That(deck, Is.Not.EqualTo(new int[] { 1,2,3,4,5,6 })); // must not have same order, small chance of failing even with correct implementation so rerun tests if fails
    }

    [Test]
    public void ShouldShuffleAnIntDeckDifferentlyEachTime()
    {
        int[] startingDeck = new int[] { 1,2,3,4,5,6 };
        int[] shuffledDeck1 = new int[] { 1,2,3,4,5,6 };
        int[] shuffledDeck2 = new int[] { 1,2,3,4,5,6 };

        Shuffle.shuffleDeck(shuffledDeck1);
        Shuffle.shuffleDeck(shuffledDeck2);
 
        Assert.That(shuffledDeck1, Is.Not.Null);
        Assert.That(shuffledDeck1, Is.EquivalentTo(startingDeck));  // must have same contents in any order
        Assert.That(shuffledDeck2, Is.Not.Null);
        Assert.That(shuffledDeck2, Is.EquivalentTo(startingDeck));
        Assert.That(startingDeck, Is.Not.EqualTo(shuffledDeck1).Or.Not.EqualTo(shuffledDeck2)); // must not be same order as at least one of the shuffled decks, .00019% chance of failing even with correct implementation so rerun tests if fail
    }

    [Test]
    public void ShouldShuffleACardDeckInPlace() {
        Card[] deck = new Card[2];
        deck[0] = new Card(id: 1, suit: Suit.Spade, value: 1);
        deck[1] = new Card(id: 2, suit: Suit.Spade, value: 2);
        Card[] startingDeck = new Card[2];
        Array.Copy(deck, startingDeck, 2);

        Shuffle.shuffleDeck(deck);
        Debug.Log(Utils.stringifyCardDeck(deck));

        Assert.That(deck, Is.Not.Null);
        Assert.That(deck, Is.EquivalentTo(startingDeck));
        Assert.That(deck, Is.Not.EqualTo(startingDeck));
    }   

}
