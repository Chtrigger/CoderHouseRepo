using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject[] enemyPrefabs;
    public float startDelay = 1;
    public float spawnInterval = 1f;


    void Start()
    {
        Disparar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], transform.position, enemyPrefabs[enemyIndex].transform.rotation);
    }

    void Disparar()
    {
        InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
    }
}
