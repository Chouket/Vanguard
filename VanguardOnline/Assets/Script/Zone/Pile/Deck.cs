using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : PileZone {

	// Use this for initialization
	void Start ()
    {
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

    //Top of the deck is the end of the card Array
    public void PutOnTop(BaseCard card)
    {
        AddCard(card);
        UpdateCardPosition();
    }

    //Bottom of the deck is the beginning of the card Array
    public void PutOnBottom(BaseCard card)
    {
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

    private void UpdateCardPosition()
    {
        Vector3 pos = transform.position;
        int cardNb = _cards.Count;
        for (int idx = 0; idx < cardNb; idx++)
        {
            _cards[idx].transform.position = pos + (0.01f * idx * Vector3.back);
        }
    }

    protected override void UpdateCardCurrentZone(BaseCard card) 
    {
        card.SetCurrentZone(ZONE.DECK);
    }

}
