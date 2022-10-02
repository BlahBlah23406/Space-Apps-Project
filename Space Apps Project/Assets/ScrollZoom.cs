using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollZoom : MonoBehaviour
{
    [SerializeField]
    private float ScrollSpeed;
    private Camera ZoomCamera;
    public Transform crossHair;
    public void Start()
    {
        string telescope = PlayerPrefs.GetString("telescope");
        if (telescope.Equals("Kepler"))
        {
            ScrollSpeed = numbers.scrollspeedkep;
        }
        else if (telescope.Equals("Hubble"))
        {
            ScrollSpeed = numbers.scrollspeedhub;
        }
        else if (telescope.Equals("James Webb"))
        {
            ScrollSpeed = numbers.scrollspeedjwst;
        }
        else if (telescope.Equals("Chandra X-Ray"))
        {
            ScrollSpeed = numbers.scrollspeedcha;
        }
        else if (telescope.Equals("Voyager One"))
        {
            ScrollSpeed = numbers.scrollspeedvoy;
        }
        
    }

    void Update()
    {
        float scrollWheel = Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
        ZoomCamera.orthographicSize -= scrollWheel;
        crossHair.transform.localScale = new Vector3(scrollWheel, scrollWheel, 0);
        


    }
}
