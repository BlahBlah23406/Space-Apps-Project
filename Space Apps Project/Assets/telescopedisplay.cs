using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telescopedisplay : MonoBehaviour

{
    public GameObject kepler;

    public GameObject chandra;

    public GameObject hubble;

    public GameObject voyager1;

    public GameObject jwst;

    public string telescope;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("telescope"))
        {
            telescope = PlayerPrefs.GetString("telescope", "Kepler");
        }
        else
        {
            PlayerPrefs.SetString("telescope", "Kepler");
            PlayerPrefs.Save();
        }
        
        if (telescope.Equals("Kepler"))
        {
            kepler.SetActive(true);
            chandra.SetActive(false);
            hubble.SetActive(false);
            voyager1.SetActive(false);
            jwst.SetActive(false);
        }
        else if (telescope.Equals("Hubble"))
        {
            kepler.SetActive(false);
            chandra.SetActive(false);
            hubble.SetActive(true);
            voyager1.SetActive(false);
            jwst.SetActive(false);
        }
        else if (telescope.Equals("James Webb"))
        {
            kepler.SetActive(false);
            chandra.SetActive(false);
            hubble.SetActive(false);
            voyager1.SetActive(false);
            jwst.SetActive(true);
        }
        else if (telescope.Equals("Chandra X-Ray"))
        {
            kepler.SetActive(false);
            chandra.SetActive(true);
            hubble.SetActive(false);
            voyager1.SetActive(false);
            jwst.SetActive(false);
        }
        else if (telescope.Equals("Voyager One"))
        {
            kepler.SetActive(false);
            chandra.SetActive(false);
            hubble.SetActive(false);
            voyager1.SetActive(true);
            jwst.SetActive(false);
        }
    }

    
}
