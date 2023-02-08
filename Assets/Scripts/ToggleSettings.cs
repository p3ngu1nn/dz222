using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ToggleSettings : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI toggle;
    [SerializeField] GameObject[] Toggle = new GameObject[3];

    public void ToggleInput(int index)
    {
        if (index == 0)
        {
            toggle.text = "First Clicked";
        }

        if (index == 1)
        {
            toggle.text = "Second Clicked";
        }

        if (index == 2)
        {
            toggle.text = "Third Clicked";
        }
    }
}
