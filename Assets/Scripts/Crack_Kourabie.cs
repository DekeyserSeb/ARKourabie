using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crack_Kourabie : MonoBehaviour
{
    public GameObject brokenVersion;

    private void OnMouseDown()
    {
        //Instantiate(brokenVersion, transform.position, transform.rotation);
        gameObject.SetActive(false);
        brokenVersion.SetActive(true);
    }
}
