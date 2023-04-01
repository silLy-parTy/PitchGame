using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomLitPercentage : MonoBehaviour
{
    public Text textbox;

    private void Start()
    {
        textbox.text = "0%";
    }

    public void setText(string newText)
    {
        textbox.text = newText;
    }
}