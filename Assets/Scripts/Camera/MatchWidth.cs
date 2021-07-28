using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchWidth : MonoBehaviour
{
    [SerializeField] private float _sceneWidth = 10;

    private Camera _camera;

    void Start()
    {
        _camera = GetComponent<Camera>();
        UpdateCamera();
    }

    void UpdateCamera()
    {
        float unitsPerPixel = _sceneWidth / Screen.width;

        float desiredHalfHeight = 0.5f * unitsPerPixel * Screen.height;

        _camera.orthographicSize = desiredHalfHeight;
    }
}
