using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crack_Kourabie : MonoBehaviour
{
    public GameObject BrokenVersion;
    public GameObject EventToLaunch;

    private void OnMouseDown()
    {
        //Instantiate(brokenVersion, transform.position, transform.rotation);
        gameObject.SetActive(false);
        BrokenVersion.SetActive(true);
        EventToLaunch.SetActive(true);
    }
}
