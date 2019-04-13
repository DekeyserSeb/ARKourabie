using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_SetActive : MonoBehaviour
{
    public Toggle toggle;
    public GameObject Kour_Whole;
    public GameObject Kour_Broken;
    public GameObject Sugar;

    public void ToggleSet()
    {
        if (Kour_Whole != null && Kour_Broken != null && Sugar != null)
        {
            if (toggle.isOn)
            {
                this.gameObject.SetActive(false);
                //Debug.Log("QR_Code Target deactivated");
            }
            else
            {
                this.gameObject.SetActive(true);
                Kour_Whole.SetActive(true);
                Kour_Broken.SetActive(false);
                Sugar.SetActive(false);
            }
        }
    }

}
