using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Start_AR : MonoBehaviour
{
    public GameObject Kourabie;
    public GameObject Kourabie_Broken;
    public GameObject Sugar_Particules;
    public GameObject ImageTarget_Top;
    public GameObject ImageTarget_Bottom;
    public GameObject ImageTargetQR;
    public Toggle toggle;

    private bool mVuforiaStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        VuforiaARController vuforia = VuforiaARController.Instance;

        if (vuforia != null)
            vuforia.RegisterVuforiaStartedCallback(StartAfterVuforia);
    }


    void StartAfterVuforia()
    {
        mVuforiaStarted = true;
        if (Kourabie !=null && Kourabie_Broken != null && Sugar_Particules != null && ImageTarget_Top != null && ImageTarget_Bottom != null && ImageTargetQR != null && toggle != null)
        {
        //all true to initialize correctly the AR Camera with all targets
        ImageTargetQR.SetActive(true);
        ImageTarget_Top.SetActive(true);
        ImageTarget_Bottom.SetActive(true);

        //to get only the good objects actives
        Kourabie.SetActive(true);
        Kourabie_Broken.SetActive(false);
        Sugar_Particules.SetActive(false);

        //toggle.isOn = false;
        //to start with Kourabie Box image target
        toggle.isOn = true;
        Debug.Log("Toggle is On thanks to the script Start_AR");
        }
    }
}
