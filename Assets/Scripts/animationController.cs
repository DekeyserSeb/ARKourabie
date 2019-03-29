using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    public Animator anim;
    bool state = false; //=true when already broken, = false when it can be break

    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (!state)
        {
            anim.Play("Kourabie_Break");
            anim.Play("Default_State");
        }
        else
        {

            anim.Play("Kourabie_Break_Reverse");
            anim.Play("Default_State");
        }
    }
}
