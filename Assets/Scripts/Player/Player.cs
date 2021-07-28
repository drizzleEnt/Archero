using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageble
{
    [SerializeField] private int _heath;

    public static bool IsVictory { get; set; }

    public void ApplyDamage(int damage)
    {
        _heath -= damage;
        if (_heath <= 0)
            Die();            
    }

    private void Die()
    {
        IsVictory = false;
        GameEnd.Instance.EndGame();
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Enemy enemy))
            ApplyDamage(10);
    }
}
