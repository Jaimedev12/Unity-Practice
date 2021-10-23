using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObject : MonoBehaviour
{

    public GameObject obstacle;
    public float timeInterval;

    float spawnX = 18;
    Vector3 spawnPos;
    float spawnTime;


    void Start()
    {

        spawnTime = timeInterval + Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            spawnPos = new Vector3(spawnX, Random.Range(-3f, 3.8f), 0);
            Instantiate(obstacle, spawnPos, Quaternion.identity);

            spawnTime += timeInterval;

        }

    }
}
