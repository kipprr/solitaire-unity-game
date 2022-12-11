using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UpdateSprite : MonoBehaviour
{
    public Sprite cardFace;
    public Sprite cardBack;
    private Deck deckScript;
    private SpriteRenderer spriteRenderer;
    private Selectable selectable;

    // Start is called before the first frame update
    void Start()
    {
        deckScript = FindObjectOfType<Deck>();
        cardFace = deckScript.cardFaces[Int32.Parse(this.name)-1];

        spriteRenderer = GetComponent<SpriteRenderer>();
        selectable = GetComponent<Selectable>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (selectable.isFaceUp == true){
            spriteRenderer.sprite = cardFace;
        } else {
            spriteRenderer.sprite = cardBack;
        }
    }
}
