using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    static private InputManager instance = null;
    static public InputManager Instance
    {
        get
        {
            if (instance == null)
                instance = new InputManager();
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
