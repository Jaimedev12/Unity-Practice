using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCarro : MonoBehaviour
{

    [SerializeField] float velocidadFrente = 15f;
    [SerializeField] float velocidadGiro = 10f;

    float inputX;
    float inputZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        //Moverse adelante
        transform.Translate(new Vector3(0, 0, velocidadFrente) * Time.deltaTime * inputZ);

        //Girar a los lados
        transform.Rotate(Vector3.up, Time.deltaTime * inputX * velocidadGiro);
    }
}
