using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityLitPercentage : MonoBehaviour
{
    public Text textbox;

    private void Start()
    {
            textbox.text = "0%";
    }

    void setText(string newText)
    {
        textbox.text = newText;
    }
}
