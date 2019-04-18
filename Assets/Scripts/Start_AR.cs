using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Start_AR : MonoBehaviour
{
    public GameObject ImageTarget_Top;
    public GameObject ImageTarget_Bottom;
    public GameObject ImageTargetQR;
    public GameObject toggleSwitchBoxQR;

    private bool mVuforiaStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        if (ImageTarget_Top != null && ImageTarget_Bottom != null && ImageTargetQR != null && toggleSwitchBoxQR != null)
        {
            //all true to initialize correctly the AR Camera with all targets
            ImageTargetQR.SetActive(true);
            ImageTarget_Top.SetActive(true);
            ImageTarget_Bottom.SetActive(true);
            //to activate it later
            //toggleSwitchBoxQR.SetActive(false);

            VuforiaARController vuforia = VuforiaARController.Instance;
            //crucial to launch Vuforia before setting the toggle : because incative target will not be taken into account by AR camera at the first launch
            if (vuforia != null)
                vuforia.RegisterVuforiaStartedCallback(StartAfterVuforia);
        }
    }


    void StartAfterVuforia()
    {
        if (ImageTarget_Top != null && ImageTarget_Bottom != null && ImageTargetQR != null && toggleSwitchBoxQR != null)
        {
            mVuforiaStarted = true;
            //to activate SCAN MODE : Kourabie Box 
            toggleSwitchBoxQR.GetComponent<Toggle>().isOn = true;
            toggleSwitchBoxQR.GetComponent<Toggle_SwitchBoxQR_SetActiveElements>().ToggleSet();
            toggleSwitchBoxQR.GetComponent<Toggle_SwitchBoxQR_ChangeText>().textUpdate();
        }
    }
}
