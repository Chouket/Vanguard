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
            TakeDamage();
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

    public void Discard()
    {
        //Select a Card
        BaseCard cardToDiscard = _hand.GetRandomCard();
        _hand.RemoveCard(cardToDiscard);
        _dropZone.AddCard(cardToDiscard);
    }

    public void TakeDamage()
    {
        BaseCard cardChecked = _deck.Draw();
        _damageZone.AddCard(cardChecked);
    }


    [SerializeField] private Deck _deck;
    [SerializeField] private Hand _hand;
    [SerializeField] private DropZone _dropZone;
    [SerializeField] private DamageZone _damageZone;
}
