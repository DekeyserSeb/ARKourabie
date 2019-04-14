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
    public Toggle toggleAR;
    public Toggle toggleInst;

    private bool mVuforiaStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        VuforiaARController vuforia = VuforiaARController.Instance;
        //crucial to launch Vuforia before setting the toggle : because incative target will not be taken into account by AR camera at the first launch
        if (vuforia != null)
            vuforia.RegisterVuforiaStartedCallback(StartAfterVuforia);
    }


    void StartAfterVuforia()
    {
        mVuforiaStarted = true;
        if (ImageTarget_Top != null && ImageTarget_Bottom != null && ImageTargetQR != null && toggleAR != null && toggleInst != null)
        {
            //all true to initialize correctly the AR Camera with all targets
            ImageTargetQR.SetActive(true);
            ImageTarget_Top.SetActive(true);
            ImageTarget_Bottom.SetActive(true);

            ////to start with Kourabie Box image target
            //toggleAR.isOn = true;
            //Debug.Log("Toggle AR is ON thanks to the script Start_AR");
            
            ////to start with hidden right things
            //toggleInst.isOn = true;
            //Debug.Log("Toggle Inst is ON thanks to the script Start_AR");

            ////to get a more reactive scroll in Instruction panel and preserve resources when Camera is not used
            //this.gameObject.SetActive(false);
            //Debug.Log("AR Cam inactive");
        }
    }
}
