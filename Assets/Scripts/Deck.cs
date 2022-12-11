using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
   public Sprite[] cardFaces;
   public GameObject cardPrefab;
   public List<Card> deckList;

   public List<Card> generateDeck() {
        List<Card> deck = new List<Card>();
        Suit[] suits = new Suit[] {Suit.Club, Suit.Diamond, Suit.Heart, Suit.Spade};
        for (int s = 0; s < 4; s++) {
            for (int v = 0; v < 13; v++) {
                deck.Add(new Card(id: s*13 + v +1, suit: suits[s], value: v+1, cardFaceSprite: cardFaces[s*13 + v], isFaceUp: true));
            }
        }
        return deck;
   }

   public void buildDeck(List<Card> deck) {
        foreach(Card card in deck) {
            GameObject newCard = Instantiate(cardPrefab, transform.position, Quaternion.identity);
            newCard.name = card.getId().ToString();
        }
   }
        

    void Awake() {

        deckList = generateDeck();
        buildDeck(deckList);

    }

   void Start()
    {
        
        Shuffle.shuffleDeck(deckList);

        
    }
    
}
