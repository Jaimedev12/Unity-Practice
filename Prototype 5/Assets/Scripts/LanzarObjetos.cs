using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarObjetos : MonoBehaviour
{

    private Rigidbody targetRb;

    float minForce = 9f;
    float maxForce = 14.5f;
    float torqueRange = 10f;
    float randomPosRangeX = 4.3f;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomUpwardsForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = new Vector3(RandomPositionX(), -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 RandomUpwardsForce()
    {
        return Vector3.up * Random.Range(minForce, maxForce);
    }

    float RandomTorque()
    {
        return Random.Range(-torqueRange, torqueRange);
    }

    float RandomPositionX()
    {
        return Random.Range(-randomPosRangeX, randomPosRangeX);
    }
}
