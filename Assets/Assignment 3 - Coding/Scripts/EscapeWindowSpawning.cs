// Date:8-11-23
// Name:Fiona Owen
// Organisation:Swansea University


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The script is used for spawning the teleport window at different spawn points.
public class EscapeWindowSpawning: MonoBehaviour
{
    [SerializeField]
    private GameObject escapeWindowPrefab;
    [SerializeField]
    private GameObject[] spawnPoints;


    // Start is called before the first frame update
    void Start()
    {
        WindowSpawning();
    }

    public void WindowSpawning()
    {
        if(spawnPoints.Length > 0) 
        {
            int randomIndex = Random.Range(0, 5); //spawnPoints.Length);
            GameObject spawn = spawnPoints[randomIndex];
            Instantiate(escapeWindowPrefab, spawn.transform.position, spawn.transform.rotation);
        }
        else
        {
            Debug.Log("Spawnpoint length is not greater than zero or Spawnpoints are not assigned.");
           
        }
       
    }


}
