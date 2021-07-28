using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RunState : PlayerStates
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;

    private Rigidbody _rigidbody;
    private Vector2 _direction;
    private Joystick _joystick;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _joystick = FindObjectOfType<Joystick>();
    }

    private void OnDisable()
    {
        _rigidbody.velocity = Vector3.zero;
    }

    private void Update()
    {
        _direction = _joystick.Direction;
    }

    private void FixedUpdate()
    {
        Move();   
    }

    private void Move()
    {
        Vector3 targetDirection = new Vector3(transform.position.x + _direction.x, transform.position.y, transform.position.z + _direction.y);
        Vector3 lookDirection = targetDirection - transform.position;
        Vector3 direction = new Vector3(_direction.x * _speed, _rigidbody.velocity.y, _direction.y * _speed);
        Quaternion rotation = Quaternion.LookRotation(lookDirection);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, _rotationSpeed);
        _rigidbody.velocity = direction;
    }
}
