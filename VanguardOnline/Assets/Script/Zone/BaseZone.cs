using UnityEngine;
using System.Collections;


public abstract class BaseZone : MonoBehaviour
{
    enum ZONE
    {
        NONE = 0,
        DECK,
        HAND,
        DROP,
        SOUL,
        BIND,
        TRIGGER,
        REARGUARD,
        VANGUARD,
        GUARDIAN//,
        //GENERATION
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    protected abstract void UpdateCardCurrentZone();
}
