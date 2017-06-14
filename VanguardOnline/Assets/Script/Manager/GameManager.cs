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

    void Start ()
    {
        _stepManager = new StepManager();
        _playerManager = PlayerManager.Instance;
        _networkManager = NetworkManager.Instance;
    }
	
	void Update ()
    {
	}
}
