using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSettings : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI button;
    [SerializeField] GameObject[] ButtonGO = new GameObject[3];

    public void ButtonInput(int index)
    {
        if (index == 0)
        {
            button.text = "One Clicked";
        }

        if (index == 1)
        {
            button.text = "Two Clicked";
        }

        if (index == 2)
        {
            button.text = "Disabled";
 
        }
    }
}
