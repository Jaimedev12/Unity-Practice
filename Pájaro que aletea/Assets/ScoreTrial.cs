using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTrial : MonoBehaviour
{
    private TextMeshProUGUI textComponent;
    float score;

    // Start is called before the first frame update
    void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = "Holiwis";
        score++;
    }
}
