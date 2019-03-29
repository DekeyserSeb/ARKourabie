using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();    
    }

 

    private void OnMouseDown()
    {
        anim.Play("Kourabie_Break");
        //anim.ResetTrigger("Kourabie_Break");
    }
}
