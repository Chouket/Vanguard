using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

    static private NetworkManager instance = null;
    static public NetworkManager Instance
    {
        get
        {
            if (instance == null)
                instance = new NetworkManager();
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
