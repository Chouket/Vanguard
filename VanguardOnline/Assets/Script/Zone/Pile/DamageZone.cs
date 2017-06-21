using UnityEngine;
using System.Collections;

public class DamageZone : BasePile {

    // Use this for initialization
    new void Start()
    {
        base.Start();
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public int GetDamageCount()
    {
        return _cards.Count;
    }
   
    public int GetFaceUpCount()
    {
        int faceUpNb = 0;

        int cardNb = _cards.Count;
        for (int idx = 0; idx < cardNb; idx++)
        {
            //if (_cards[idx].isFlip)
                faceUpNb++;
        }
        return faceUpNb;
    }        

    protected override void UpdateCardPosition()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;
        int cardNb = _cards.Count;
        Vector3 offset = Vector3.back * 0.01f + Vector3.down * 0.32f;

        for (int idx = 0; idx < cardNb; idx++)
        {
            _cards[idx].transform.position = pos + idx * offset;
            _cards[idx].transform.rotation = rot;
        }
    }

    protected override void UpdateCardCurrentZone(BaseCard card)
    {
        card.SetCurrentZone(ZONE.DAMAGE);
    }
}
