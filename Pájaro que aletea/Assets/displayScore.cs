using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class displayScore : MonoBehaviour
{
    public float points;
    TextMeshProUGUI textComponent;


    private void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            points += 1;
            Debug.Log(points);
        }
    }

    void Update()
    {
        textComponent.text = points.ToString();
    }

}
