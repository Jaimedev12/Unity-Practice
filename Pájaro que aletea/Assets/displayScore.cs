using UnityEngine;
using TMPro;

public class displayScore : MonoBehaviour
{
    public float points;
    public TextMeshProUGUI textComponent;
    TextMeshProUGUI txt;

    private void Start()
    {
        txt = textComponent.GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "CenterCollider")
        {
            points++;
        }
    }

    void Update()
    {
        txt.text = points.ToString();
    }

}
