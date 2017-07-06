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
            {
                GameObject obj = Instantiate(Resources.Load("Prefabs/Manager/GuiManager")) as GameObject;
                instance = obj.GetComponent<GuiManager>();
            }
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
    public CardActionUI _cardActionUI = null;
}
