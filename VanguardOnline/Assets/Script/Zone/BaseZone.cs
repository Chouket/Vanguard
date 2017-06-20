using UnityEngine;
using System.Collections;


public abstract class BaseZone : MonoBehaviour
{
    public enum ZONE
    {
        NONE = 0,
        DECK,
        HAND,
        DAMAGE,
        DROP,
        SOUL,
        BIND,
        TRIGGER,
        REARGUARD,
        VANGUARD,
        GUARDIAN,
        GENERATION
    }


    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public abstract void AddCard(BaseCard card);

    public abstract void RemoveCard(BaseCard card);

    protected abstract void UpdateCardPosition() /*= 0*/;

    protected abstract void UpdateCardCurrentZone(BaseCard card) /*= 0*/;
}
