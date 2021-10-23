using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flap : MonoBehaviour
{

    public float velocityMultiplier;
    public Rigidbody2D birdRB;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdRB.velocity = Vector2.up * velocityMultiplier;
        }

    }
}
