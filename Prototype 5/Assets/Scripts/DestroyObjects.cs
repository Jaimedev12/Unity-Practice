using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{

    private GameManager gameManager;
    public ParticleSystem pointPS;
    public int pointValue = 1;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            Destroy(gameObject);

            if (!gameObject.CompareTag("Bomb"))
            {
                GameOver();
            }  
        }
    }

    private void OnMouseDown()
    {
        if (!gameManager.isGameOver)
        {
            Destroy(gameObject);
            gameManager.UpdateScore(pointValue);
            Instantiate(pointPS, transform.position, pointPS.transform.rotation);
        }
    }

    void GameOver()
    {
        gameManager.isGameOver = true;
        gameManager.restartButton.gameObject.SetActive(true);
        gameManager.gameOverText.gameObject.SetActive(true);
    }
}
