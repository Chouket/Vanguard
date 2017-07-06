using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerManager : MonoBehaviour {

    static private PlayerManager instance = null;
    static public PlayerManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = Instantiate(Resources.Load("Prefabs/Manager/PlayerManager")) as GameObject;
                instance = obj.GetComponent<PlayerManager>();
            }
            return instance;
        }
    }

    public CardsCollection tmpDeck = null;

	void Start ()
    {
        _player = FindObjectOfType<Player>();
        string path = Application.dataPath + "/CardsInfos/JsonCards/ShadowPaladin.json";
        tmpDeck = transform.GetComponent<JsonParser>().LoadJson(path);
        List<BaseCard> cards = transform.GetComponent<JsonParser>().JsonCardsToBaseCard(tmpDeck);
        _player.Deck.AddDeck(cards);
	}
	
    
	void Update ()
    {
	}

    public Player _player;
}
