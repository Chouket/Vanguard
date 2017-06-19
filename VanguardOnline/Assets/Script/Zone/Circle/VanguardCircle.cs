using UnityEngine;
using System.Collections;

public class VanguardCircle : BaseOneCard
{

    // Use this for initialization
    new void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Ride(BaseCard card)
    {
        AddToSoul(card);
        AddCard(card);
    }

    public void AddToSoul(BaseCard card)
    {
        _soul.AddCard(card);
    }

    protected override void UpdateCardPosition()
    {
        _card.transform.position = transform.position;
    }

    protected override void UpdateCardCurrentZone(BaseCard card)
    {
        _card.SetCurrentZone(ZONE.VANGUARD);
    }

    [SerializeField] Soul _soul;
}