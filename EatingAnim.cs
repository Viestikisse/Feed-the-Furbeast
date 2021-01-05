using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingAnim : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void OnMouseOver()
    {
        anim.SetBool("isEating", true);
    }

    void OnMouseExit()
    {
        anim.SetBool("isEating", false);
    }
}
