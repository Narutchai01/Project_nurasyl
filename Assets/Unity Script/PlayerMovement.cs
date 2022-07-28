using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool attack = false;
    bool attack2 = false;
    bool attack3 = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (controller.m_Grounded == false)
        {
            animator.SetBool("OnAir", true);

        }else
        {
            animator.SetBool("OnAir", false);
        }
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            
        }
        if (Input.GetButtonDown("Attack"))
        {
            attack = true;
            animator.SetTrigger("Attack");
        }
        if (Input.GetButtonDown("Attack2"))
        {
            attack2 = true;
            animator.SetTrigger("Attack2");
        }
        if (Input.GetButtonDown("Attack3"))
        {
            attack3 = true;
            animator.SetTrigger("Attack3");
        }
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }

    void FixedUpdate ()
    {
        //Move character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
        attack = false;
        attack2 = false;
        attack3 = false;
    }
}
