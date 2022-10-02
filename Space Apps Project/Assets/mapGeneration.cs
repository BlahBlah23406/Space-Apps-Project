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
        for (var i = 0; i < 10; i++)
        {
            //planet generation
            
                Instantiate(gasGiant, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
                
                Instantiate(neptunian, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
                
                Instantiate(terrestial, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);

                Instantiate(superEarth, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
                
                //star generation
                Instantiate(hotBlueStar, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
                
                Instantiate(neutronStar, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
                
                Instantiate(redDwarfStar, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
                
                Instantiate(solarTypeStar, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
                
                Instantiate(whiteDwarfStar, new Vector3(Random.Range(-500,500), Random.Range(-500,500), 0), Quaternion.identity).SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
