using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    public GameObject Kourabie;
    public GameObject Kourabie_Broken;

    public Animator anim;
    bool broken = false; //=true when is broken, = false when it isn't broken
    bool restart = false;

    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (!restart)
        {

            if (!broken)
            {
                anim.Play("Kourabie_Break");
                broken = true;
            }
            else if (broken)
            {
                anim.Play("Kourabie_Break_Reverse");
                Debug.Log("Done with playing backward");
                broken = false;
                restart = true;
            }
        }
        else if (restart)
        {
            anim.gameObject.SetActive(false);
            Kourabie.SetActive(true);
            restart = false;
        }
    }
}
