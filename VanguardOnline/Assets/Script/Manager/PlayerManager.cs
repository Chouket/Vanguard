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
        //Change When 2 player got there !
        _player = FindObjectOfType<Player>();
        //Debug.Log("PLayer Manager got player :" + _player.name);
	}
	
    
	void Update ()
    {
	}

    public Player _player;
}
