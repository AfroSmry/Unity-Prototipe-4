using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;
    private float spaunRange = 9;
    public int enemyCount;
    public int waweNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWawe(waweNumber);
        Instantiate(powerUpPrefab, RandomSpawnPosition(), powerUpPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            Instantiate(powerUpPrefab, RandomSpawnPosition(), powerUpPrefab.transform.rotation);
            waweNumber++;
            SpawnEnemyWawe(waweNumber);
        }
            
    }
    
    private Vector3 RandomSpawnPosition()
    {
        float spawnX = Random.Range(-spaunRange, spaunRange);
        float spawnZ = Random.Range(-spaunRange, spaunRange);
        Vector3 spawnPos = new Vector3(spawnX, 0, spawnZ);
        return spawnPos;
    }
    
    void SpawnEnemyWawe(int enemyesTiSpawn)
    {
        for (int i = 0; i < enemyesTiSpawn; i++)
        {
            Instantiate(enemyPrefab, RandomSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
}
