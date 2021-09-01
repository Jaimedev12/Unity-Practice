using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstaculo;
    public Vector3 startingPos = new Vector3(20, 0, 0);
    public float startDelay = 2f;
    public float spawnRate = 2f;
    private PlayerController playerControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        InvokeRepeating("SpawnObstaculo", startDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstaculo()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaculo, startingPos, obstaculo.transform.rotation);
        }
    }
}
