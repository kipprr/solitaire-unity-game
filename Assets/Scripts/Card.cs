using System;
using System.Collections;

public enum Suit {
    Club,
    Diamond,
    Heart,
    Spade
}

public enum Color {
    Black,
    Red
}

public class Card {
    private int  _id;
    private bool _isFaceUp;
    private Suit _suit;
    private Color _color;
    private int _value;

    public Card(int id, Suit suit, int value, bool isFaceUp = false) {
        if( value < 1 | value > 13) {
            throw new ArgumentException("Parameter must be between 1 and 13", nameof(value));
        }
        _id = id;
        _suit = suit;
        _value = value;
        _isFaceUp = isFaceUp;
        if (_suit == Suit.Heart | _suit == Suit.Diamond) {
            _color = Color.Red;
        } else {
            _color = Color.Black;
        }
    }

    public int getId() {
        return _id;
    }

    public Suit getSuit() {
        return _suit;
    }

    public int getValue() {
        return _value;
    }

    public Color getColor() {
        return _color;
    }

    public bool getIsFaceUp() {
        return _isFaceUp;
    }

    public void setIsFaceUp(bool isFaceUp) {
        _isFaceUp = isFaceUp;
    }

}