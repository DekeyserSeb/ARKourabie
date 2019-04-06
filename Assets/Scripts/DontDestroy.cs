using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using Vuforia;

public class DontDestroy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        Debug.Log("dont destroy took into account ! There is hope ma friend");
    }

}
