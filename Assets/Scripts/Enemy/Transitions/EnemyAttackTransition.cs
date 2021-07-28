using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackTransition : EnemyTransitions
{
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _playerLayer;

    private void FixedUpdate()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, _radius, _playerLayer);
        if(colliders.Length > 0)
        {
            TargetState.Target = colliders[0].transform;
            EnemyMachine.Transit(TargetState);
        }
    }
}
