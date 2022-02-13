using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBlock : MonoBehaviour
{
    public float bounceHeight = 0.5f;
    public float bounceSpeed = 4f;

    private Vector2 originalPosition;
    private bool canBounce = true;

    public CoinCounter coinCounter;


    public Sprite emptyBlockSprite;


    public ScoreScript scoreScript;



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
             coinCounter.coinValue += 1;
            coinCounter.score.text = coinCounter.coinValue.ToString();

            scoreScript.scoreValue += 100;
            scoreScript.score.text = scoreScript.scoreValue.ToString();
        }
        
    }


    void ChangeSprite()
    {
        GetComponent<SpriteRenderer>().sprite = emptyBlockSprite;
    }


    IEnumerator Bounce()
    {

        ChangeSprite();

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
            QuestionBlockBounce();

            
        }
        
    }

}
