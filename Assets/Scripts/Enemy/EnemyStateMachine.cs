using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    [SerializeField] private EnemyStates _firstState;

    private EnemyStates _currentState;

    private EnemyStates CurrentState => _currentState;


    private void Start()
    {
        ResetState(_firstState);
    }

    private void ResetState(EnemyStates nextState)
    {
        _currentState = nextState;
        if (_currentState != null)
            _currentState.Switch();
    }

    public void Transit(EnemyStates nextState)
    {
        if (_currentState != null)
            _currentState.Switch();

        ResetState(nextState);
    }
}
