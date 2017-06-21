using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CardInspectorUI : MonoBehaviour {

	void Start ()
    {
        _cardPicture = transform.GetChild(0).GetComponent<RawImage>();
        _cardName = transform.GetChild(1).GetComponent<Text>();
        _cardText = transform.GetChild(2).GetComponent<Text>();
        _cardInfo = transform.GetChild(3).GetComponent<Text>();
    }
	
	void Update ()
    {
	}

    public void CardToDisplay(BaseCard card)
    {
        _cardText.text = card.CurrentStats._name;
    }

    private RawImage _cardPicture = null;
    private Text _cardName = null;
    private Text _cardText = null;
    private Text _cardInfo = null;

}
