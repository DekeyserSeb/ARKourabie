﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_AR : MonoBehaviour
{
    public GameObject Kourabie;
    public GameObject Kourabie_Broken;

    // Start is called before the first frame update
    void Start()
    {
        Kourabie.SetActive(true);
        Kourabie_Broken.SetActive(false);
    }
}