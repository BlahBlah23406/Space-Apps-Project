using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class buttonManagerShop : MonoBehaviour
{
    
    
    public static string telescope = "";
    public Text kelper;

    public Text voyager;

    public Text hubbletelescope;

    public Text chandratelescope;

    public Text jameswebbtelescope;
    // Start is called before the first frame update
    
    void Start()
    {
        if (PlayerPrefs.HasKey("telescope"))
        {
            telescope = PlayerPrefs.GetString("telescope", "Kepler");
            equpping(telescope);
        }
        else
        {
            PlayerPrefs.SetString("telescope", "Kepler");
            PlayerPrefs.Save();
        }
        
        

    }
    
    public void voyagerOne()
    {
        
        equpping("Voyager One");
        
    }

    public void chandra()
    {
        equpping(("Chandra X-Ray"));
    }

    public void back()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void kepler()
    {
        equpping("Kepler");
    }

    public void hubble()
    {
        equpping("Hubble");
    }

    public void jwst()
    {
        equpping("James Webb");
    }

    public void equpping(string telescope)
    {
        string previoustelescope = PlayerPrefs.GetString("telescope", "Kepler");
        if (previoustelescope.Equals("Kepler"))
        {
            kelper.text = "Equip";
        }
        else if (previoustelescope.Equals("Hubble"))
        {
            hubbletelescope.text = "Equip";
        }
        else if (previoustelescope.Equals("James Webb"))
        {
            jameswebbtelescope.text = "Equip";
        }
        else if (previoustelescope.Equals("Chandra X-Ray"))
        {
            chandratelescope.text = "Equip";
        }
        else if (previoustelescope.Equals("Voyager One"))
        {
            voyager.text = "Equip";
        }
        
        PlayerPrefs.SetString("telescope", telescope);
        PlayerPrefs.Save();
        if (telescope.Equals("Kepler"))
        {
            kelper.text = "Equipped";
        }
        else if (telescope.Equals("Hubble"))
        {
            hubbletelescope.text = "Equipped";
        }
        else if (telescope.Equals("James Webb"))
        {
            jameswebbtelescope.text = "Equipped";
        }
        else if (telescope.Equals("Chandra X-Ray"))
        {
            chandratelescope.text = "Equipped";
        }
        else if (telescope.Equals("Voyager One"))
        {
            voyager.text = "Equipped";
        }
    }


    
}
