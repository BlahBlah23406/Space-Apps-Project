using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winloseManager : MonoBehaviour
{
    public Text text;

    private void Start()
    {
        int winLose = PlayerPrefs.GetInt("winLose");
        if (winLose == 0)
        {
            text.text = "Congratulations! You successfully completed your mission!";
        }
        else
        {
            text.text = "You failed yuour missions";
        }
    }

    public void home()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void shop()
    {
        SceneManager.LoadScene("ShopScene");
    }
    public void again()
    {
        SceneManager.LoadScene("MissionScene");
    }
}
