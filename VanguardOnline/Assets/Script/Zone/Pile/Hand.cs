using UnityEngine;
using System.Collections;


public class Hand : PileZone {

    void Start ()
    {
        Shuffle();
    }
	
	
	void Update ()
    {
       // Shuffle();
    }

    public override void AddCard(BaseCard card)
    {
        if (!card)
            return;

        base.AddCard(card);
        UpdateCardPosition();
    }

    public void Discard(BaseCard card)
    {
        RemoveCard(card);
        UpdateCardPosition();
    }

    void Shuffle()
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

    void UpdateCardPosition()
    {
        Vector3 left = transform.position - Vector3.right * (_handGraphicSize / 2f);
        Vector3 right = transform.position - Vector3.left * (_handGraphicSize / 2f);
        Vector3 delta = right - left;

        int cardNb = _cards.Count;
        float gapsNb = cardNb - 1;
        Vector3 gap = delta / gapsNb;

        for (int idx = 0; idx < cardNb; idx++)
        {
            Vector3 lisibilityOffset = idx * 0.01f * Vector3.forward;
            _cards[idx].transform.position = left + (gap * idx) + lisibilityOffset;
        }
    }

    protected override void UpdateCardCurrentZone(BaseCard card) 
    {
        card.SetCurrentZone(ZONE.HAND);
    }

    const float _handGraphicSize = 5f;
}
