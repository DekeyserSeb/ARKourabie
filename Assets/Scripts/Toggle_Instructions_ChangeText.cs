using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_Instructions_ChangeText : MonoBehaviour
{
    private Text Label;

    public void textUpdate()
    {
        Label = gameObject.GetComponentInChildren<Text>();
        if (gameObject.GetComponent<Toggle>().isOn)
        {
            Label.text = "Leave Instructions";
        }
        else
        {
            Label.text = "See Instructions";
        }
    }
}
