using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActivateText : MonoBehaviour
{

    private TMP_Text debugText;
    private bool isOn = true;

    public string letter = "W";

    // Start is called before the first frame update
    void Start()
    {
        debugText = GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(letter))
        {
            debugText.gameObject.SetActive(isOn);
            
            if (isOn == true)
            {
                isOn = false;
            } else
            {
                isOn = true;
            }

        }
    }
}
