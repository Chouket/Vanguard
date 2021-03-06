﻿using UnityEngine;
using System.Collections;


public class Hand : BasePile
{

    new void Start()
    {
        base.Start();
        Shuffle();
    }
	
	
	void Update ()
    {
       
    }

    public BaseCard GetRandomCard()
    {
        int rand = Random.Range(0, _cards.Count - 1);
        return _cards[rand];
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
        Quaternion rot = transform.rotation;
        Vector3 left = _leftAnchor.transform.position;
        Vector3 right = _rightAnchor.transform.position;
        Vector3 delta = right - left;

        int cardNb = _cards.Count;
        float gapsNb = cardNb - 1;
        Vector3 offset = 0.01f * Vector3.back;

        //evade delta/0 case
        Vector3 gap = (gapsNb != 0) ? delta / gapsNb + offset : delta;


        for (int idx = 0; idx < cardNb; idx++)
        {
            _cards[idx].transform.position = left + (gap * idx);
            _cards[idx].transform.rotation = rot;
        }
    }

    protected override void UpdateCardCurrentZone(BaseCard card) 
    {
        card.SetCurrentZone(ZONE.HAND);
    }

    [SerializeField] private GameObject _leftAnchor;
    [SerializeField] private GameObject _rightAnchor;
}
