using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToggleGameObject : MonoBehaviour
{

    public GameObject objeto;
    public string tecla = "W";

    private bool turnOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            objeto.gameObject.SetActive(turnOn);
            turnOn = !turnOn;
        }

        
    }
}
