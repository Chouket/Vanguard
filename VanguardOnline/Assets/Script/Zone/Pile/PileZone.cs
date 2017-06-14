using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class PileZone : BaseZone {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public virtual void AddCard(BaseCard card)
    {
        _cards.Add(card);
        UpdateCardCurrentZone(card);
    }

    public void RemoveCard(BaseCard card)
    {
        _cards.Remove(card);
    }

    protected override abstract void UpdateCardCurrentZone(BaseCard card);

    [SerializeField] //to remove
     protected List<BaseCard> _cards;
}
