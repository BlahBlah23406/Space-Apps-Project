using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class buttonManager : MonoBehaviour
{
    public static void missionButton()
    {
        SceneManager.LoadScene("MissionScene");
    }

    public static void closeButton()
    {
        Application.Quit();
    }

    public static void shopButton()
    {
        SceneManager.LoadScene("ShopScene");
    }
}
