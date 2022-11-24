using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{

     public static string stringifyIntArr(int[] arr) {
        string str = "[";
        foreach (int i in arr)
        {
            str = str + i + ", ";
        }
        str += "]";
        return str;
     }

     public static string stringifyCardDeck(Card[] deck, bool abbreviated = false) {
        string str = "[";
        foreach (Card card in deck)
        {
            str = str + stringify(card, abbreviated) + ", ";
        }
        str += "]";
        return str;
     }

    public static string stringify(Card card, bool abbreviated = false) {
        string str = "";
        if (abbreviated) {
            str = $"{card.getId()}({card.getSuit().ToString()[0]}{valueToString(card.getValue())})";
        } else {
            str = $"Card #{card.getId()}, {valueToString(card.getValue())} of {card.getSuit()} ({card.getColor()})";
        }
        return str;
    }

    public static string valueToString(int value) {
        if (value == 1) {
            return "A";
        }
        if (value == 11) {
            return "J";
        }
        if (value == 12) {
            return "Q";
        }
        if (value == 13 ) {
            return "K";
        }
        if (value > 1 && value < 11) {
            return value.ToString();
        }
        return "Invalid value";
    }
    
}
