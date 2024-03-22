using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playascript : MonoBehaviour
{

    Rigidbody2D rb2d;

    public float movespeed = 5;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float vx = Input.GetAxis("Horizontal") * movespeed;
        float vy = Input.GetAxis("Vertical") * movespeed;


        rb2d.velocity = new Vector2(vx, vy);
    }
}