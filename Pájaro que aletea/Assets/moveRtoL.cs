using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRtoL : MonoBehaviour
{

    public float velocity = 10;
    public Transform obstacleTransform;

    // Update is called once per frame
    void Update()
    {
        obstacleTransform.Translate(Vector3.left * Time.deltaTime * velocity);
    }
}
