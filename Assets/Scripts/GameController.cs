using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        int[] startingDeck = new int[] { 1,2,3,4,5,6 };
        int[] shuffledDeck1 = Shuffle.shuffleDeck(startingDeck);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
