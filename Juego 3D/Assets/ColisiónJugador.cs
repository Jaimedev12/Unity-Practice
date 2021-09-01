using UnityEngine;

public class ColisiónJugador : MonoBehaviour
{

    public MovimientoJugador movimiento;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstaculo")
        {
            movimiento.enabled = false;
        }

    }

}
