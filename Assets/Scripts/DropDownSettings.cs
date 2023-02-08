using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropDownSettings : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dropdown;

    public void DropDownInput(int index)
    {
        if (index == 0)
        {
            dropdown.text = "Option A";
        }

        if (index == 1)
        {
            dropdown.text = "Option B";
        }

        if (index == 2)
        {
            dropdown.text = "Option C";
        }      
    }
}
