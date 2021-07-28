using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTransition : PlayerTransition
{
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _enemyLayer;

    private void FixedUpdate()
    {
        
        Collider[] colliders = Physics.OverlapSphere(transform.position, _radius, _enemyLayer);
        
        if (colliders.Length == 0)
            return;

        if (colliders[0].TryGetComponent(out Enemy enemy))
        {
            TargetState.Target = enemy.transform;
            PlayerMachine.Transit(TargetState);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, _radius);
    }
}
