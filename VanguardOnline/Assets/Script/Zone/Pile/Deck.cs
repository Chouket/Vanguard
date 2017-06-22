using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : BasePile {

    // Use this for initialization
    new void Start()
    {
        base.Start();
        Shuffle();
    }
	
	// Update is called once per frame
	void Update ()
    {
       
    }

    //Remove Top card and return it
    public BaseCard Draw()
    {
        int last = _cards.Count - 1;
        if (last < 0)
        {
            print("YOU LOOSE");
            return null;
        }

        BaseCard cardToDraw = _cards[last];
        RemoveCard(cardToDraw);

        return cardToDraw;
    }

    //Bottom of the deck is the beginning of the card Array
    public void PutOnBottom(BaseCard card)
    {
        if (!card)
            return;

        _cards.Insert(0, card);
        UpdateCardCurrentZone(card);
        UpdateCardPosition();
    }

    // Get X Card From the top of the deck in a List
    public List<BaseCard> GetXCardFromTop(int x)
    {
        List<BaseCard> topCards = new List<BaseCard>();

        int cardNb = _cards.Count - 1;
        for (int i = cardNb; i > cardNb - x; i--)
            topCards.Add(_cards[_cards.Count - 1]);

        return topCards;
    }

    public void Shuffle()
    {
        int cardNb = _cards.Count;
        for (int id = 0; id < cardNb; id++)
        {
            BaseCard tmpCard = _cards[id];
            int rand = Random.Range(id, cardNb);
            _cards[id] = _cards[rand];
            _cards[rand] = tmpCard;
        }

        UpdateCardPosition();
    }


    protected override void UpdateCardPosition()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;
        int cardNb = _cards.Count;
        Vector3 offset = Vector3.back * 0.01f;

        for (int idx = 0; idx < cardNb; idx++)
        {
            _cards[idx].transform.position = pos + offset * idx;
            _cards[idx].transform.rotation = rot;
        }
    }

    protected override void UpdateCardCurrentZone(BaseCard card) 
    {
        card.SetCurrentZone(ZONE.DECK);
    }

}
