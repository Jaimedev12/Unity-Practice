using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    public GameObject powerupPrefab;

    public int enemiesAlive;
    public int enemiesPerLevel = 1;


    // Start is called before the first frame update
    void Start()
    {   
        SpawnNewWave(1);
        Instantiate(powerupPrefab, GenerateRandomPosition(), powerupPrefab.gameObject.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemiesAlive = FindObjectsOfType<Enemy>().Length;

        if (enemiesAlive == 0)
        {
            SpawnNewWave(enemiesPerLevel);
            Instantiate(powerupPrefab, GenerateRandomPosition(), powerupPrefab.gameObject.transform.rotation);
        }
    }

    void SpawnNewWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateRandomPosition(), enemyPrefab.transform.rotation);
        }

        enemiesPerLevel++;
    }

    private Vector3 GenerateRandomPosition()
    {
        float randomPosX = Random.Range(-10, 10);
        float randomPosZ = Random.Range(-10, 10);
        Vector3 randomPos = new Vector3(randomPosX, 0.15f, randomPosZ);

        return randomPos;
    }
}
