using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_Instructions_SetActiveElements : MonoBehaviour
{
    public GameObject Back_Button;
    public GameObject ToggleAR;
    public GameObject Panel_Inst;

    // Start is called before the first frame update
    //script for more control on the behaviour when it is On or not
    public void SetActiveElements()
    {
        if (this.gameObject.GetComponent<Toggle>().isOn)
        {
            //Back_Button.SetActive(false);
            //ToggleAR.SetActive(false);
            Panel_Inst.SetActive(true);
        }
        else
        {
            //Back_Button.SetActive(true);
            //ToggleAR.SetActive(true);
            Panel_Inst.SetActive(false);
        }
    }
}
