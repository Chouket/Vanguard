using UnityEngine;
using System.Collections;

public class GuiManager : MonoBehaviour
{
    static private GuiManager instance = null;
    static public GuiManager Instance
    {
        get
        {
            if (instance == null)
                instance = new GuiManager();
            return instance;
        }
    }

    // Use this for initialization
    void Start ()
    {
        instance = this;
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public CardInspectorUI _cardInspectorUI = null;
}
