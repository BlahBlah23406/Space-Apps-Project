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
    public Button button;
    string[] missionPlanet = { "Gas Giant", "Neptunian", "Super-Earth", "Terrestial" };
    string[] missionStar = { "Solar-type Stars", "Hot Blue Stars", "Red Dwarf Stars", "White Dwarfs", "Neutron Stars" };

    public static int planetIndex = 0;

    public static int starIndex = 0;

    public void missionGenerator()
    {
        planetIndex = Random.Range(1, 5) - 1;
        starIndex = Random.Range(1, 7) - 1;
        string planetType = missionPlanet[planetIndex];
        string starType = missionStar[starIndex];
        text.text = planetType + " " + starType;

    }
    void Start()
    {
        missionGenerator();
    }
    
    public static void onButtonPressed()
    {
        SceneManager.LoadScene("Game");
    }
}