using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class crosshair : MonoBehaviour
{
    public string classification;

    private void Start()
    {
        int index = PlayerPrefs.GetInt("index");
        classification = sceneControol.missionThing[index];
        Debug.Log(classification);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey("space") && other.tag.Equals(classification))
        {
            PlayerPrefs.SetInt("winLose", 0); 
            PlayerPrefs.Save();
            SceneManager.LoadScene("DecisionScene");
        }
        
        else if (Input.GetKey("space") && !other.tag.Equals(classification))
        {
            PlayerPrefs.SetInt("winLose", 1); 
            PlayerPrefs.Save();
            SceneManager.LoadScene("DecisionScene");
        }

        
    }
}
