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

    protected override abstract void UpdateCardCurrentZone(BaseCard card);

    [SerializeField] //to remove
     protected List<BaseCard> _cards;
}
