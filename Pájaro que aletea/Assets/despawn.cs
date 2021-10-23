using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawn : MonoBehaviour
{

    public float despawnX;

    void Update()
    {
     
        if (gameObject.transform.position.x < despawnX)
        {
            Destroy(gameObject);
        }
        
    }
}
