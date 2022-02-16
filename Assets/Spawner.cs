using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public float spawnAfterThisTime;
    public float timeBetweenSpawns;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnAfterThisTime, timeBetweenSpawns);
    }

    public void SpawnEnemy() {
        Instantiate(enemyToSpawn, gameObject.transform.position, Quaternion.identity);
    }
}
