using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStayTransition : EnemyTransitions
{
    [SerializeField] private float _attackDistance;

    private Transform _player;

    private void OnEnable()
    {
        _player = FindObjectOfType<Player>().transform;
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, _player.position) > _attackDistance)
            EnemyMachine.Transit(TargetState);
    }
}
