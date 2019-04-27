using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_SwitchBoxQR_SetActiveElements : MonoBehaviour
{
    //public GameObject ;
    public GameObject ImageTarget_Top;
    public GameObject ImageTarget_Bottom;
    public GameObject ImageTarget_QR;

    public void ToggleSet()
    {
        if (ImageTarget_Top != null && ImageTarget_Bottom != null && ImageTarget_QR != null)
        {
            if (gameObject.GetComponent<Toggle>().isOn) //SCAN MODE : Kourabie Box
            {
                ImageTarget_Top.SetActive(true);
                ImageTarget_Bottom.SetActive(true);
                ImageTarget_QR.SetActive(false);
            }
            else //SCAN MODE : QR Code
            {
                ImageTarget_Top.SetActive(false);
                ImageTarget_Bottom.SetActive(false);
                ImageTarget_QR.SetActive(true);
                Debug.Log("QR_Code Target activated");
            }
        }
    }

}
