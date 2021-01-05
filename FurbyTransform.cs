using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurbyTransform : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CompareTag("TriggerButton"))
        {
            anim.SetBool("Furbeast", true);
        }
    }
}
