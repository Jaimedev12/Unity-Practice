using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private Animator playerAnim;
    private AudioSource playerAudio;

    public ParticleSystem explisionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;

    public float jumpForce = 20;
    public float downForce = 5;
    public float gravityMultiplier = 2;
    public bool gameOver = false;
    private bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && gameOver == false)
        {
            //Efecto de sonido
            playerAudio.PlayOneShot(jumpSound, 1.5f);

            //Salta
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            //Animación
            playerAnim.SetTrigger("Jump_trig");

            isOnGround = false;

            //Detener partículas de tierra si está en el aire
            dirtParticle.Stop();
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerRB.AddForce(Vector3.down * downForce, ForceMode.Acceleration);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (gameOver == false)
            {
                isOnGround = true;

                dirtParticle.Play();
            }
        }
        
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //Efecto de sonido
            playerAudio.PlayOneShot(crashSound, 2f);

            explisionParticle.Play();
            dirtParticle.Stop();

            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);

            gameOver = true;
        }
    }
}
