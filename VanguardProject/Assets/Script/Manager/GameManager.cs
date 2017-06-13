using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    static private GameManager instance = null;
    static public GameManager Instance
    {
        get
        {
            if (instance == null)
                instance = new GameManager();
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
