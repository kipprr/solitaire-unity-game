using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

    public static class Shuffle {
        
        public static int[] shuffleDeck(int[] deck) {
            for (int i = deck.Length - 1; i > 0; i--) {
                int randomIndex = RandomNumberGenerator.GetInt32(0, i+1);

                int temp = deck[i];
                deck[i] = deck[randomIndex];
                deck[randomIndex] = temp;
            }
            return deck;
        }

        public static List<Card> shuffleDeck(List<Card> deck) {
            for (int i = deck.Count - 1; i > 0; i--) {
                int randomIndex = RandomNumberGenerator.GetInt32(0, i+1);
                Card temp = deck[i];
                deck[i] = deck[randomIndex];
                deck[randomIndex] = temp;
            }
            return deck;
        }

    }