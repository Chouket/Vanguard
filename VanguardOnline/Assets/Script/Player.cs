using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    const int MAX_LIFE_POINT = 6;

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(1) && _lastCallCoroutine != null)
            StopCoroutine(_lastCallCoroutine);
	}

    public void CardSelected(BaseCard cardSelected)
    {
        Discard();
    }

    // here ?
    public void Draw()
    {
        BaseCard cardDrawn = _deck.Draw();
        _hand.AddCard(cardDrawn);
    }

    public void Discard()
    {
        //Select a Card
        BaseCard cardToDiscard = _hand.GetRandomCard();
        _hand.RemoveCard(cardToDiscard);
        SendToDropZone(cardToDiscard);
    }

    public void SendToDropZone(BaseCard card)
    {
        _dropZone.AddCard(card);
    }

    public void Ride(BaseCard card)
    {
        Debug.Log("Ride !");
        _hand.RemoveCard(card);
        _vanguardCircle.AddCard(card);
    }

    public void Call(BaseCard card)
    {
        _lastCallCoroutine = StartCoroutine(CallFromHand(card));   
    }

    public void TakeDamage()
    {
        if (_damageZone.GetDamageCount() == MAX_LIFE_POINT)
        {
            Loose();
            return;
        }

        BaseCard cardChecked = _deck.Draw();
        _damageZone.AddCard(cardChecked);
    }

    private void Loose()
    {
        Debug.Log("YOU LOOSE !");
    } 

    private IEnumerator CallFromHand(BaseCard card)
    {
        Debug.Log("Waiting for Circle !");
        yield return new WaitUntil(() => _selectedCircle != null);
        _hand.RemoveCard(card);
        _selectedCircle.AddCard(card);
        _selectedCircle = null;
        _lastCallCoroutine = null;
    }

    Coroutine _lastCallCoroutine = null;
    [HideInInspector] public BaseZone _selectedCircle;

    //MEMBERS
    //Circle
    [SerializeField] private VanguardCircle _vanguardCircle;
    [SerializeField] private RearguardCircle _topLeftRearguardCircle;
    [SerializeField] private RearguardCircle _topRightRearguardCircle;

    [SerializeField] private RearguardCircle _botLeftRearguardCircle;
    [SerializeField] private RearguardCircle _botCenterRearguardCircle;
    [SerializeField] private RearguardCircle _botRightRearguardCircle;

    //Zone
    [SerializeField] private Deck _deck;
    [SerializeField] private Hand _hand;
    [SerializeField] private DropZone _dropZone;
    [SerializeField] private DamageZone _damageZone;
}
