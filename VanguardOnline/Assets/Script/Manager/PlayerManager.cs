using UnityEngine;
using System.Collections;

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

	void Start ()
    {
        _player = FindObjectOfType<Player>();
	}
	
    
	void Update ()
    {
	}

    public void tmpAddCardInPlayerHand()
    {
    }

    public Player _player;
}
