using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBlock : MonoBehaviour
{
    public float bounceHeight = 0.5f;
    public float bounceSpeed = 4f;

    private Vector2 originalPosition;
    private bool canBounce = true;

    

    public Sprite emptyBlockSprite;

    public HealthScript healthScript;



    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.localPosition;
    }

    public void QuestionBlockBounce()
    {
        if (canBounce)
        {
            canBounce = false;
            StartCoroutine(Bounce());
            


        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeSprite()
    {
        GetComponent<SpriteRenderer>().sprite = emptyBlockSprite;
    }


    IEnumerator Bounce()
    {


        while (true)
        {
            transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y + bounceSpeed * Time.deltaTime);

            if (transform.localPosition.y >= originalPosition.y + bounceHeight)
                break;

            yield return null;
        }
        while (true)
        {
            transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - bounceSpeed * Time.deltaTime);
            if (transform.localPosition.y <= originalPosition.y)
            {
                transform.localPosition = originalPosition;
                break;
            }
            yield return null;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            if (healthScript.currentHealth == 1)
            {
                QuestionBlockBounce();
            }

            if (healthScript.currentHealth == 2)
            {
                Destroy(gameObject);
            }
            
        }

    }
}
