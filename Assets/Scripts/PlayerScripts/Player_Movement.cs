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

    public int jumpValue; 

    public Animator animator;

    public AudioSource audioSource;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

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
        if (horizontalInput > 0.01f)
            transform.eulerAngles = new Vector2(0, 0);
            
        else if (horizontalInput < -0.01f)
        {
            transform.eulerAngles = new Vector2(0, 180); //flip the character on its x axis
        }

        //Running
        if (Input.GetKeyDown(KeyCode.L))
        {
            speed = 13;
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            speed = 10;
        }

        


    }

    private void Jump()
    {

        audioSource.Play();
        body.velocity = new Vector2(body.velocity.x, jumpValue);
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
