using UnityEngine;
using System.Collections;

public class StepManager : MonoBehaviour {

    public enum GamePhase
    {
        IddlePhase = 0,
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
        IddleStep = 0,
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
        _currentPhase = GamePhase.IddlePhase;
        _currentStep = GameStep.IddleStep;
	}
	
	void Update ()
    {
	}
}
