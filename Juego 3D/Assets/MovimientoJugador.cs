using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{

    public float velocidad = 1000f;
    public Rigidbody rb;
    public float fuerzaLados = 2000f;

    // Update is called once per frame
    public void FixedUpdate()
    {
        rb.AddForce(0, 0, velocidad * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(fuerzaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-fuerzaLados * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}