using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    const int deckLimit = 52;

    private Card[] deck;

    // Start is called before the first frame update
    void Start()
    {
        deck = new Card[deckLimit];
    }

    public void setup() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
