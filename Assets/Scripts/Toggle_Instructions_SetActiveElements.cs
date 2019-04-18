using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Toggle_Instructions_SetActiveElements : MonoBehaviour
{
    public GameObject Back_Button;
    public GameObject Panel_Inst;
    public GameObject ARCamera;

    // Start is called before the first frame update
    //script for more control on the behaviour when it is On or not
    public void Start()
    {
        gameObject.GetComponent<Toggle>().isOn = true;
        SetActiveElements();
    }

    public void SetActiveElements()
    {
        if (Back_Button != null && Panel_Inst != null && ARCamera != null)
        {
            if (this.gameObject.GetComponent<Toggle>().isOn)
            {
                //ARCamera.SetActive(false);
                //Debug.Log("ARCam inactive");
                ARCamera.GetComponentInChildren<VuforiaBehaviour>().enabled = false;
                Debug.Log("AR Vuforia Behaviour is disabled");
                Back_Button.SetActive(false);
                Debug.Log("Back btn inactive");
                Panel_Inst.SetActive(true);
                Debug.Log("Inst Panel inactive");
            }
            else
            {
                //ARCamera.SetActive(true);
                ARCamera.GetComponentInChildren<VuforiaBehaviour>().enabled = true;
                Back_Button.SetActive(true);
                Panel_Inst.SetActive(false);
            }
        }
    }
}
