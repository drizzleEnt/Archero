using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _damage;

    private Transform _target;
    private Rigidbody _rigidbody;
    private float gravity = Physics.gravity.y;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, 3f);
    }


    public void Init(Transform target)
    {
        _target = target;
        Move();
    }

    private void Move()
    {
        _rigidbody.velocity = Vector3.zero;
        Debug.Log(_target.name);
        Vector3 fromTo = _target.position - transform.position;
        Vector3 fromToXZ = new Vector3(fromTo.x, 0, fromTo.z);

        float x = fromToXZ.magnitude;
        float y = fromTo.y;
        float angle = 45 * Mathf.PI / 180;
        float v2 = (gravity * x * x) / (2 * (y - Mathf.Tan(angle) * x) * Mathf.Pow(Mathf.Cos(angle), 2));
        float v = Mathf.Sqrt(Mathf.Abs(v2));
        _rigidbody.velocity = transform.forward * v;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out IDamageble enemy))
        {
            enemy.ApplyDamage(_damage);
            Destroy(gameObject);
        }
    }
}
