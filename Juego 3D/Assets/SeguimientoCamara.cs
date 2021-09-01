using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{

    public Vector3 diferencia;
    public Transform jugador;

    // Update is called once per frame
    void Update()
    {
        transform.position = jugador.position + diferencia;
    }
}
