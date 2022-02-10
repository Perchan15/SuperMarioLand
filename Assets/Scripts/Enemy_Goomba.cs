using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Goomba : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    bool facingLeft;

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD

=======
        
>>>>>>> 530922524b68edf367a39a373eca8df2cfcb1e97
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
<<<<<<< HEAD
        if (collision != null && !collision.collider.CompareTag("Player") && collision.collider.CompareTag("ground"))
=======
        if (collision !=null && !collision.collider.CompareTag("player") && collision.collider.CompareTag("ground"))
>>>>>>> 530922524b68edf367a39a373eca8df2cfcb1e97
        {
            facingLeft = !facingLeft;
        }

        if (facingLeft)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        else
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
<<<<<<< HEAD



    }
}
=======
    }
}

>>>>>>> 530922524b68edf367a39a373eca8df2cfcb1e97
