using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneWalking : MonoBehaviour
{
    public Vector3 endingLocation;
    public float speed;
    public Animator animator;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endingLocation, speed * Time.deltaTime);
        if (transform.position.x >= endingLocation.x)
        {
            animator.SetBool("isMoving", false);
        }
    }
}
