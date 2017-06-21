using UnityEngine;
using System.Collections;

public class StepManager : MonoBehaviour
{
    static private StepManager instance = null;
    static public StepManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = Instantiate(Resources.Load("Prefabs/Manager/StepManager")) as GameObject;
                instance = obj.GetComponent<StepManager>();
            }
            return instance;
        }
    }

    public enum GamePhase
    {
        IdlePhase = 0,
        StandPhase,
        DrawPhase,
        RidePhase,
        MainPhase,
        BattlePhase,
        EndPhase
    }

    private GamePhase _currentPhase;

    public enum GameStep
    {
        //Generic
        IdleStep = 0,
        // DrawPhase
        DrawStep,
        GAssistStep,
        // RidePhase
        RideStep,
        StrideStep,
        //BattlePhase
        StartStep,
        AttackStep,
        GuardStep,
        DriveStep,
        DamageStep,
        CloseStep,
    }
    private GameStep _currentStep;

	void Start ()
    {
        _currentPhase = GamePhase.IdlePhase;
        _currentStep = GameStep.IdleStep;
	}
	
	void Update ()
    {


	}
}
