using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyStateMachine))]
public class EnemyTransitions : MonoBehaviour
{
    [SerializeField] private EnemyStates _targetState;

    protected EnemyStateMachine EnemyMachine;

    public bool NeedTransit { get; protected set; }

    public EnemyStates TargetState => _targetState;

    private void Awake()
    {
        EnemyMachine = GetComponent<EnemyStateMachine>();
    }
}
