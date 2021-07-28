using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageble
{
    [SerializeField] private int _health;

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
            Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
