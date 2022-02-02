using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_script : MonoBehaviour
{
    public Transform target;
    public Transform leftBounds;
    public Transform rightBounds;

    public float smoothDampTime = 0f;
    private Vector3 smoothDampVelocity = Vector3.zero;

    private float camWidth, camHeight, levelMinX, levelMaxX;


    public bool move;

    private void FixedUpdate()
    {
        {
            Follow();
        }
    }

    void Follow()
    {
        camHeight = Camera.main.orthographicSize * 2;
        camWidth = camHeight * Camera.main.aspect;

        float leftBoundsWidth = leftBounds.GetComponentInChildren<SpriteRenderer>().bounds.size.x / 2;
        float rightBoundWidt = rightBounds.GetComponentInChildren<SpriteRenderer>().bounds.size.x / 2;

        levelMinX = leftBounds.position.x + leftBoundsWidth + (camWidth / 2);
        levelMaxX = rightBounds.position.x - rightBoundWidt - (camWidth / 2);


    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            float targetX = Mathf.Max(levelMinX, Mathf.Min(levelMaxX, target.position.x));
            float x = Mathf.SmoothDamp(transform.position.x, targetX, ref smoothDampVelocity.x, smoothDampTime);
            transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            move = true;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            move = false;
        }

    }
}
