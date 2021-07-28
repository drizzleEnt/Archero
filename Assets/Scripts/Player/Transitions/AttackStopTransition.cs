using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackStopTransition : PlayerTransition
{
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _enemyLayer;

    private void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, _radius, _enemyLayer);

        if (colliders.Length == 0)
            PlayerMachine.Transit(TargetState);
    }
}
