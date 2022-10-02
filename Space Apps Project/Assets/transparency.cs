using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparency : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float Transparency;
    public void Start()
    {
        
        string telescope = PlayerPrefs.GetString("telescope");
        if (telescope.Equals("Kepler"))
        {
            Transparency = numbers.camerablurkep;
        }
        else if (telescope.Equals("Hubble"))
        {
            Transparency = numbers.camerablurhub;
        }
        else if (telescope.Equals("James Webb"))
        {
            Transparency = numbers.camerablurjwst;
        }
        else if (telescope.Equals("Chandra X-Ray"))
        {
            Transparency = numbers.camerablurcha;
        }
        else if (telescope.Equals("Voyager One"))
        {
            Transparency = numbers.camerablurvoy;
        }

        Transparency = 23.0f;
        GetComponent<SpriteRenderer>(). color = new Color(0.0f, 0.0f, 0.0f,23.0f);
    }

    public void Update()
    {
    }
}
