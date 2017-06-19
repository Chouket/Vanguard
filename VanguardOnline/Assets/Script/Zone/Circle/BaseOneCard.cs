using UnityEngine;
using System.Collections;

public abstract class BaseOneCard : BaseZone {

    // Use this for initialization
    protected void Start ()
    {
        if (_card)
            UpdateCardCurrentZone(_card);
    }

    // Update is called once per frame
    void Update ()
    {
	
	}

    public override void AddCard(BaseCard card)
    {
        if (!card)
            return;

        _card = card;

        UpdateCardCurrentZone(_card);
        UpdateCardPosition();
    }

    public override void RemoveCard(BaseCard card)
    {
        _card = null;
    }

    protected override abstract void UpdateCardPosition();

    protected override abstract void UpdateCardCurrentZone(BaseCard card);

    //Members

    protected BaseCard _card = null;
}
