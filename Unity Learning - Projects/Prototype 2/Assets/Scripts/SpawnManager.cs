using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangex = 15;
    private float spawnPosz = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private float spawnRangez = 10;
    private float spawnPosx = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex), 0, spawnPosz);
 
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
            
        Vector3 spawnPos = new Vector3(-spawnPosx, 0, Random.Range(0, spawnRangez));
        Quaternion spawnRotation = Quaternion.Euler(0, 90, 0);

        Instantiate(animalPrefabs[animalIndex], spawnPos, spawnRotation);
    }
    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(spawnPosx, 0, Random.Range(0, spawnRangez));
        Quaternion spawnRotation = Quaternion.Euler(0, 270, 0);

        Instantiate(animalPrefabs[animalIndex], spawnPos, spawnRotation);
    }

}
