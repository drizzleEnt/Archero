using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSystem : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _target;
    private float _offset;

    private void Start()
    {
        _target = FindObjectOfType<Player>().transform;
        _offset = _target.position.z - transform.position.z;
    }

    private void Update()
    {
        Vector3 target = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, _target.position.z - _offset), _speed * Time.deltaTime);
        transform.position = target;
    }
}
