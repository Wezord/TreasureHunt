using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Manager.current.onClickOnChest += openChest;
    }

    public void openChest(bool isOpen){
        if(!isOpen){
            animator.SetBool("openChest", true);
        }
        else{
            animator.SetBool("openChest", false);
        }
    }
}
