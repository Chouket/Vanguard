using UnityEngine;
using System.Collections;

public class Cardmanager : MonoBehaviour {

    static private Cardmanager instance = null;
    static public Cardmanager Instance
    {
        get
        {
            if (instance == null)
                instance = new Cardmanager();
            return instance;
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}




}
