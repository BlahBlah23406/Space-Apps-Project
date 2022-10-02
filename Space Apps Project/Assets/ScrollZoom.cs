using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollZoom : MonoBehaviour
{
    [SerializeField]
    private float ScrollSpeed = 25;
    private Camera ZoomCamera;
    public Transform crossHair;
    private void Start()
    {
        
    }

    void Update()
    {
        float scrollWheel = Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
        ZoomCamera.orthographicSize -= scrollWheel;
        crossHair.transform.localScale = new Vector3(scrollWheel, scrollWheel, 0);


    }
}
