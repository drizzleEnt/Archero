using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpecialAttack : EnemyStates
{
    [SerializeField] private float _attackDeley;
    [SerializeField] private SpecialBullet _bulletPrefab;
    [SerializeField] private Transform _spawnPoint;

    private float _currentTime;

    private void OnEnable()
    {
        _currentTime = _attackDeley;
    }

    private void OnDisable()
    {
        Target = null;
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime >= _attackDeley)
        {
            Attack();
            _currentTime = 0;
        }
    }

    private void Attack()
    {
        if (Target == null)
            return;
        LookAtTarget();

        SpecialBullet bullet = Instantiate(_bulletPrefab, _spawnPoint.position, _spawnPoint.rotation);
        bullet.Init(Target);
    }

    private void LookAtTarget()
    {
        Vector3 direction = Target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = lookRotation;
    }
}
