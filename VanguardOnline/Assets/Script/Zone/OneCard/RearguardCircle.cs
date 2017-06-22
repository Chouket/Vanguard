using UnityEngine;
using System.Collections;

public class RearguardCircle : BaseOneCard {

	// Use this for initialization
	new void Start ()
    {
        base.Start();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnMouseDown()
    {
        Debug.Log("Click on Rear Circle : " + name);
        PlayerManager.Instance._player._selectedCircle = this;
    }

    public override void AddCard(BaseCard card)
    {
        if (_card)
        {
            BaseCard cardRemoved = _card;
            RemoveCard(_card);
            PlayerManager.Instance._player.SendToDropZone(cardRemoved);
        }

        base.AddCard(card);
    }

    protected override void UpdateCardPosition()
    {
        _card.transform.position = transform.position;
    }

    protected override void UpdateCardCurrentZone(BaseCard card)
    {
        _card.SetCurrentZone(ZONE.VANGUARD);
    }

}
