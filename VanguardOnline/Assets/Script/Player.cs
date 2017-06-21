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
        if (count == 150)
        {
           // Draw();
            //TakeDamage();
            count = 0;
        }
	}

   static int count = 0;

    public void CardSelected(BaseCard cardSelected)
    {
        Discard();
    }

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

    public void Ride(BaseCard card)
    {
        Debug.Log("Ride !");
        _hand.RemoveCard(card);
        _vanguardCircle.Ride(card);
    }

    public void Call(BaseCard card)
    {
        StartCoroutine(WaitForCircle());
        _hand.RemoveCard(card);
        _selectedCircle.AddCard(card);
    }


    private IEnumerator WaitForCircle()
    {
        Debug.Log("Waiting for Circle !");
        yield return new WaitUntil(() => _selectedCircle != null);
    }


    //MEMBERS
    //Circle
    [SerializeField] private VanguardCircle _vanguardCircle;



    private BaseZone _selectedCircle;
    //Zone
    [SerializeField] private Deck _deck;
    [SerializeField] private Hand _hand;
    [SerializeField] private DropZone _dropZone;
    [SerializeField] private DamageZone _damageZone;
}
