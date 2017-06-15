using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
 
	}
	
	// Update is called once per frame
	void Update ()
    {
        count++;
        if (count == 300)
        {
            Draw();
            count = 0;
        }
	}

   static int count = 0;

    // here ?
    public void Draw()
    {
        BaseCard cardDrawn = _deck.Draw();
        _hand.AddCard(cardDrawn);
    }


    [SerializeField] private Deck _deck;
    [SerializeField] private Hand _hand;
}
