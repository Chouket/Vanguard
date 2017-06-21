using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    static private InputManager instance = null;
    static public InputManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = Instantiate(Resources.Load("Prefabs/Manager/InputManager")) as GameObject;
                instance = obj.GetComponent<InputManager>();
            }
            return instance;
        }
    }

    void Start ()
    {
	
	}


    void Update()
    {

    }

}
