using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb2;
    public float Speed = 30f;
    public Animator anim;
    Vector2 Movement;
    
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("hori", Movement.x);
        anim.SetFloat("vert", Movement.y);
        anim.SetFloat("Speed", Movement.sqrMagnitude);
    }

    void FixedUpdate ()
    {
        //Movement
        rb2.MovePosition(rb2.position + Movement * Speed * Time.fixedDeltaTime);
    }
}
