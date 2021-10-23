using UnityEngine;
using TMPro;

public class displayScore : MonoBehaviour
{
    public float points;
    public TextMeshProUGUI textObject;
    //TextMeshProUGUI txt;


    private void Start()
    {
        //txt = textObject.GetComponent<TextMeshProUGUI>();
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
        textObject.text = "Holiwis";
    }

}
