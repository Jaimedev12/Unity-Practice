using UnityEngine;
using TMPro;

public class displayScore : MonoBehaviour
{
    public float points;
    public TMP_Text scoreText;
    TMP_Text txtComponent;


    private void Start()
    {
        txtComponent = scoreText.GetComponent<TMP_Text>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "CenterCollider")
        {
            points += 1;
            Debug.Log(points);
        }
    }

    void Update()
    {
        txtComponent.text = points.ToString();
    }

    /*
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ay chocaste we");

        if (other.tag == "CenterCollider")
        {
            points += 1;
            Debug.Log(points);
        }
    }
    */



}
