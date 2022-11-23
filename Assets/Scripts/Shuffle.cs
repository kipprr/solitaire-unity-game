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

        public static Card[] shuffleDeck(Card[] deck) {
            // for (int i = deck.Length - 1; i > 0; i--) {
            //     int randomIndex = RandomNumberGenerator.GetInt32(0, i+1);

            //     Card temp = deck[i];
            //     deck[i] = deck[randomIndex];
            //     deck[randomIndex] = temp;
            // }
            Card temp = deck[0];
            deck[0] = deck[1];
            deck[1] = deck[0];
            return deck;
        }

    }