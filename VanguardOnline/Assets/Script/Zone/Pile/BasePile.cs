using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public abstract class BasePile : BaseZone {

	// Use this for initialization
	protected void Start ()
    {
        foreach (BaseCard card in _cards)
        {
            UpdateCardCurrentZone(card);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void AddCard(BaseCard card)
    {
        if (!card)
            return;

        _cards.Add(card);
        UpdateCardCurrentZone(card);
        UpdateCardPosition();
    }

    public override void RemoveCard(BaseCard card)
    {
        if (!card)
            return;

        _cards.Remove(card);
        UpdateCardPosition();
    }

    protected override abstract void UpdateCardPosition();

    protected override abstract void UpdateCardCurrentZone(BaseCard card);

    //Members
    [SerializeField] protected List<BaseCard> _cards;
}
