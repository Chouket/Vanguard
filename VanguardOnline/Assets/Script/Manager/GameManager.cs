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

    private StepManager _stepManager = null;
    private PlayerManager _playerManager = null;
    private NetworkManager _networkManager = null;
    private GuiManager _guiManager = null;
    private Cardmanager _cardManager = null;

    void Start ()
    {
        _stepManager = StepManager.Instance;
        _playerManager = PlayerManager.Instance;
        _networkManager = NetworkManager.Instance;
        _guiManager = GuiManager.Instance;
        _cardManager = Cardmanager.Instance;
    }
	
	void Update ()
    {
	}
}
