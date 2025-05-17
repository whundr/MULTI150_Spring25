using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            animator.SetTrigger("Hover");
        }
        if (Input.GetKeyDown("a"))
        {
            animator.SetTrigger("Color");
        }
        if (Input.GetKeyDown("s"))
        {
            animator.SetTrigger("Spin");
        }
        if (Input.GetKeyDown("d"))
        {
            animator.SetTrigger("Scale");
        }

    }
}
