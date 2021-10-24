using UnityEngine;
using UnityEngine.UI;
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
            points += 1;
            Debug.Log(points);
            txt.text = points.ToString();
        }
    }

    void Update()
    {
        //textComponent.text = points.ToString();
    }

}
