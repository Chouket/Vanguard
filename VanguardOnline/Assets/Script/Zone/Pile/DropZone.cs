﻿using UnityEngine;
using System.Collections;
using System;

public class DropZone : BasePile {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    protected override void UpdateCardPosition()
    {
        Vector3 pos = transform.position;
        int cardNb = _cards.Count;
        Vector3 offset = Vector3.back * 0.01f;

        for (int idx = 0; idx < cardNb; idx++)
        {
            _cards[idx].transform.position = pos + offset * idx;
        }
    }

    protected override void UpdateCardCurrentZone(BaseCard card)
    {
        card.SetCurrentZone(ZONE.DROP);
    }
}
