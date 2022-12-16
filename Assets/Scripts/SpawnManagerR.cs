using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerR : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangex = 24;
    private float spawnRangezBottom = -3;
    private float spawnRangezTop = 10;
    private float startDelay = 0.5f;
    private float spawnInterval = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnRangex, 0, Random.Range(spawnRangezBottom, spawnRangezTop));
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
