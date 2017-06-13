using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    static private PlayerManager instance = null;
    static public PlayerManager Instance
    {
        get
        {
            if (instance == null)
                instance = new PlayerManager();
            return instance;
        }
    }

	void Start ()
    {
	}
	
	void Update ()
    {
	}
}
