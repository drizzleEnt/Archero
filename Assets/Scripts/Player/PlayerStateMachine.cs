using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    [SerializeField] private PlayerStates _firstState;

    private PlayerStates _currentState;

    public PlayerStates CurrentState => _currentState;

    private void Start()
    {
        ResetState(_firstState);
    }


    private void ResetState(PlayerStates nextState)
    {
        _currentState = nextState;
        if (_currentState != null)
            _currentState.SwitchState();
    }

    public void Transit(PlayerStates nextState)
    {
        if(_currentState != null)
            _currentState.SwitchState();

        ResetState(nextState);
    }
}
