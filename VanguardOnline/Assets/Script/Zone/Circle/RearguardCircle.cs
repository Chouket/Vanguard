using UnityEngine;
using System.Collections;

public class RearguardCircle : BaseOneCard {

	new void Start ()
    {
        base.Start();
	}
	
	void Update ()
    {
	
	}


    void OnMouseDown()
    {
        Debug.Log("Click on Rear Circle : " + name);
        PlayerManager.Instance._player._selectedCircle = this;
    }

    void OnMouseEnter()
    {
        if (_card)
            GuiManager.Instance._cardInspectorUI.CardToDisplay(_card);
    }

    public override void AddCard(BaseCard card)
    {
        Debug.Log("AddToRear : " + card.name);
        if (_card)
        {
            Debug.Log("Removing other : " + _card.name);
            BaseCard cardRemoved = _card;
            RemoveCard(_card);
            PlayerManager.Instance._player.SendToDropZone(cardRemoved);
        }

        base.AddCard(card);
        _card.gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    public override void RemoveCard(BaseCard card)
    {
        _card.gameObject.GetComponent<BoxCollider2D>().enabled = true;
        base.RemoveCard(card);
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
