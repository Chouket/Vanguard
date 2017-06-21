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
        _cardName.text = card.CurrentStats._name;
        SpriteRenderer cardSprite = card.transform.GetChild(0).GetComponent<SpriteRenderer>();
        _cardPicture.texture = cardSprite.sprite.texture;
        _cardInfo.text = "ATK: " + card.CurrentStats._atk + " | DEF: " + card.CurrentStats._def +
            "\nGrade: " + card.CurrentStats._grade + " | Drive: " + card.CurrentStats._drive;

    }

    private RawImage _cardPicture = null;
    private Text _cardName = null;
    private Text _cardText = null;
    private Text _cardInfo = null;

}
