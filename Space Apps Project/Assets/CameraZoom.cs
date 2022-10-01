using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour

    
{
    [SerializeField]
    public float ScrollSpeed = 10;

    public Camera ZoomCamera;

    public void Update()
    {
        ZoomCamera.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
    }
}
