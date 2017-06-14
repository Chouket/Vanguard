﻿using UnityEngine;
using System.Collections;

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
