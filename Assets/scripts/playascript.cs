using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playascript : MonoBehaviour
{

    Rigidbody2D rb2d;

    public float movespeed = 5;
    Animator animator;



    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        float vx = Input.GetAxis("Horizontal") * movespeed;
        float vy = Input.GetAxis("Vertical") * movespeed;


        rb2d.velocity = new Vector2(vx, vy);

        if(rb2d.velocity == Vector2.zero)
        {
            animator.Play("Playa_Idle");
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            animator.Play("Playa_Walking_Up");
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            animator.Play("Playa_Walking_Left");
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.Play("Playa_Walking_Down");
        }

        else if ( Input.GetKeyDown(KeyCode.D ))
        {
            animator.Play("Playa_walking_right");
        }

       
    }
}
