using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CardActionUI : MonoBehaviour {

    public Button _firstAction = null;
    public Button _secondAction = null;
    public Button _thirdAction = null;

    void Start ()
    {
	}
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(1))
            ClearAction();

    }

    public void SetDeckAction(Deck deck)
    {
        _firstAction.onClick.AddListener(delegate { PlayerManager.Instance._player.Draw(); ClearAction();});
        _firstAction.transform.GetChild(0).GetComponent<Text>().text = "Draw";
        _secondAction.enabled = false;
        _thirdAction.enabled = false;
    }

    private void ClearAction()
    {
        _firstAction.onClick.RemoveAllListeners();
        _secondAction.onClick.RemoveAllListeners();
        _thirdAction.onClick.RemoveAllListeners();
        gameObject.SetActive(false);
    }
}
