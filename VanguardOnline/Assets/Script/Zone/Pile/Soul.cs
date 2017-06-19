using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Soul : BasePile
{

    new void Start()
    {
        base.Start();
    }
	
	void Update ()
    {
	
	}

    protected override void UpdateCardPosition()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;
        int cardNb = _cards.Count;
        Vector3 offset = Vector3.back * 0.1f;

        for (int idx = 0; idx < cardNb; idx++)
        {
            _cards[idx].transform.position = pos - offset;
            _cards[idx].transform.rotation = rot;
        }
    }

    protected override void UpdateCardCurrentZone(BaseCard card)
    {
        card.SetCurrentZone(ZONE.SOUL);
    }

}
