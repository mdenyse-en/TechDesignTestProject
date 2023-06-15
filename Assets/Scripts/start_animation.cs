using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_animation : MonoBehaviour
{
    [SerializeField] string animationName;
    //public AnimationClip clip;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        //Animator animator = GetComponent<Animator>();
        if (animator != null)
        {
            animator.Play(animationName);
        }
    }
}
