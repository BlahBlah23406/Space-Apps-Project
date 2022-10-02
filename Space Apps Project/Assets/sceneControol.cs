using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Random;
using UnityEngine.SceneManagement;

public class sceneControol : MonoBehaviour
{
    public Text text;
    public static string[] missionThing = { "Gas Giant", "Neptunian", "Super-Earth", "Terrestial", "Solar-type Stars", "Hot Blue Stars", "Red Dwarf Stars", "White Dwarfs", "Neutron Stars"};

    public static int index;

    public void missionGenerator()
    {
        index = Range(1, 10) - 1;
        PlayerPrefs.SetInt("index", index);
        string telescope = PlayerPrefs.GetString("telescope");
        PlayerPrefs.Save();
        string missionType = missionThing[index];
        text.text = "Your mission is find a " + missionType +". Your telescope is the " + telescope +".";

    }
    void Start()
    {
        missionGenerator();
    }
    
    public static void onButtonPressed()
    {
        
        SceneManager.LoadScene("Game");
        
    }

    public void reDraw()
    {
        missionGenerator();
    }
    
    private void Update()
    {
        
    }
}