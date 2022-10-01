using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField]
    private float ScrollSpeed = 10;
    private Camera coll;
    void Update()
    {
        coll.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
    }

}
