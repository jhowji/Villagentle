using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Physics
    public Rigidbody2D rb2;
    Vector2 Movement;
    public float Speed = 30f;
    public Collider2D coll;
    //Animation and position
    public Vector2 startPosition;
    public Vector2 backPosition;
    public Animator anim;
    public static Move instance;
    

    void Start(){
         
        coll = GetComponent<Collider2D>();

        if(instance != null){
            Destroy(this.gameObject);
            return;
        }
        
        instance = this;
        GameObject.DontDestroyOnLoad(this.gameObject);

    }
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");
        //Transform moviment valor in animation paramenter 
        anim.SetFloat("hori", Movement.x);
        anim.SetFloat("vert", Movement.y);
        anim.SetFloat("Speed", Movement.sqrMagnitude);
    }
    void FixedUpdate ()
    {
        //Movement of the player
        rb2.MovePosition(rb2.position + Movement * Speed * Time.fixedDeltaTime);
    }
     public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Respawn")){
            transform.position = startPosition;
        }
        else if(other.CompareTag("Finish")){
            transform.position = backPosition;
        }
            
    }
}
