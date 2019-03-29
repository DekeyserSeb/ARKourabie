using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    public Animator anim;
    bool broken = false; //=true when is broken, = false when it isn't broken

    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (!broken)
        {
            anim.Play("Kourabie_Break");
            broken = true;
        }
        else
        {
            anim.Play("Kourabie_Break_Reverse");
            Debug.Log("Done with playing backward");
            broken = false;
        }
    }
}
