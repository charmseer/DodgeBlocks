﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed = 15f;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal")* Time.fixedDeltaTime * speed;

        //rb.position is in (x,y) format so you can only add something
        //else in the same format. Vector2.right adds a vector that is (1,0)
        rb.MovePosition(rb.position + Vector2.right * x);
    }
}
