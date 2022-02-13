using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D body;
    private bool grounded;
    public int gravity;
    private bool Run;

    public Animator animator;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {



        //Sets speed in animation clip
        animator.SetFloat("Speed", Mathf.Abs(body.velocity.x));

        //Jumping
        if (Input.GetKey(KeyCode.K) && grounded)
        {
            Jump();
        }

        //Sets jumping boolean in animation clip
        animator.SetBool("IsJumping", grounded);

        //sprite flip
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        //Move Left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180); //flip the character on its x axis
        }

        //Running
        if (Input.GetKeyDown(KeyCode.L))
        {
            speed = 15;
            body.gravityScale = 4;
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            speed = 10;
            body.gravityScale = 2;
        }




    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        grounded = false;


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            grounded = true;

        }
    }


}
