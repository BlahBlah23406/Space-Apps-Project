using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class crosshair : MonoBehaviour
{
    
    private void OnTriggerStay2D(Collider2D other)
    {

        if (Input.GetKey("space"))
        {
            Debug.Log("Bro");
        }
    }
}
