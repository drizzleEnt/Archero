using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerStateMachine))]
public class PlayerTransition : MonoBehaviour
{
    [SerializeField] private PlayerStates _targetState;

    protected PlayerStateMachine PlayerMachine;

    public bool NeedTransit { get; protected set; }

    public PlayerStates TargetState => _targetState;

    private void Awake()
    {
        PlayerMachine = GetComponent<PlayerStateMachine>();   
    }
}
