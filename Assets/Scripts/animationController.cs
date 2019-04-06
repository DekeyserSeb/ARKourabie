using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    public GameObject Kourabie;
    public GameObject Particules;

    public Animator anim;
    bool restart = false;
    //bool anim_finished = false;

    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (!restart)
        {

            if (anim.GetCurrentAnimatorStateInfo(0).IsName("ReadyToBreak"))
            {
                anim.Play("Kourabie_Break");
                Debug.Log("Plays Forward");

                //Debug.Log("Layer index of anim not broken" + anim.GetLayerIndex("AnimLayer").ToString());
                //while (!anim_finished)
                //{
                //    Debug.Log("Layer index of anim breaking" + anim.GetLayerIndex("AnimLayer").ToString());
                //    AnimatorStateInfo animationState = anim.GetCurrentAnimatorStateInfo(anim.GetLayerIndex("AnimLayer"));
                //    AnimatorClipInfo[] myAnimatorClip = anim.GetCurrentAnimatorClipInfo(anim.GetLayerIndex("AnimLayer"));
                //    Debug.Log("Starting clip : " + myAnimatorClip[0].clip);
                //    //float currentPlayTime = myAnimatorClip[0].clip.length * animationState.normalizedTime; //--> myAnimatorClip[0]--> Out of range ?!!

                //    //if (myAnimatorClip[0].clip.length >= currentPlayTime)
                //    //{
                //    //    anim_finished = true;
                //    //}
                //}
            }
            else if (anim.GetCurrentAnimatorStateInfo(0).IsName("ReadyToReverse"))
            {
                anim.Play("Kourabie_Break_Reverse");
                Debug.Log("Plays Backward");
                restart = true;
            }
        }
        else if (restart && anim.GetCurrentAnimatorStateInfo(0).IsName("ReadyToBreak"))
        {
            gameObject.SetActive(false);
            Kourabie.SetActive(true);
            Particules.SetActive(false);
            restart = false;
        }
    }
}
