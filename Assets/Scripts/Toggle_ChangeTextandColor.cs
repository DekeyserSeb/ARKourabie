﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_ChangeTextandColor : MonoBehaviour
{
    private Text Label;

    public void onValueChanged()
    {
        Label = gameObject.GetComponentInChildren<Text>();
        if (gameObject.GetComponent<Toggle>().isOn)
        {
            Label.text = "SCAN MODE :\n Kourabie Box";
        }
        else
        {
            Label.text = "SCAN MODE :\n QR Code";
        }
    }
}
