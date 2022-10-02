using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
public class mapGeneration : MonoBehaviour
{
    public GameObject gasGiant;
    public GameObject neptunian;
    public GameObject terrestial;
    public GameObject superEarth;
    
    public GameObject hotBlueStar;
    public GameObject neutronStar;
    public GameObject redDwarfStar;
    public GameObject solarTypeStar;
    public GameObject whiteDwarfStar;
    // Start is called before the first frame update
    void Start()
    {
        string telescope = PlayerPrefs.GetString("telescope");
        int spawnRate = 0;
        if (telescope.Equals("Kepler"))
        {
            spawnRate = 4;
        }
        else if (telescope.Equals("Hubble"))
        {
            
            spawnRate = 13;
        }
        else if (telescope.Equals("James Webb"))
        {
            
            spawnRate = 20;
        }
        else if (telescope.Equals("Chandra X-Ray"))
        {
            spawnRate = 10;
        }
        else if (telescope.Equals("Voyager One"))
        {
            
            spawnRate = 6;
        }
        generation(spawnRate);
    }

    public void generation(int spawnRate)
    {
        for (var i = 0; i < spawnRate; i++)
        {
            //planet generation
            
            Instantiate(gasGiant, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
                
            Instantiate(neptunian, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
                
            Instantiate(terrestial, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);

            Instantiate(superEarth, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
                
            //star generation
            Instantiate(hotBlueStar, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
                
            
                
            Instantiate(redDwarfStar, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
                
            Instantiate(solarTypeStar, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
                
            Instantiate(whiteDwarfStar, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
        }
        Instantiate(neutronStar, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
