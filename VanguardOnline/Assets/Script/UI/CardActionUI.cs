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
        gameObject.SetActive(true);
        _firstAction.onClick.AddListener(delegate { PlayerManager.Instance._player.Draw(); ClearAction();});
        _firstAction.transform.GetChild(0).GetComponent<Text>().text = "Draw";
        _secondAction.enabled = false;
        _thirdAction.enabled = false;
    }

    public void SetMainPhaseAction()
    {
        gameObject.SetActive(true);
        Player player = PlayerManager.Instance._player;

        _firstAction.enabled = true;
        _firstAction.onClick.AddListener(delegate { player.Ride(player.CurrentCard); ClearAction(); });
        _firstAction.transform.GetChild(0).GetComponent<Text>().text = "Ride";

        _secondAction.enabled = true;
        _secondAction.onClick.AddListener(delegate { player.Call(player.CurrentCard); ClearAction(); });
        _secondAction.transform.GetChild(0).GetComponent<Text>().text = "Call";

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
