using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed = 20f;
	public int damage = 40;
	public Rigidbody2D rb;

	public ScoreScript scoreScript;
	public CoinCounter coinCounter;

	public float Timer;

	// Use this for initialization
	void Start()
	{
		rb.velocity = transform.right * speed;

		
		
	}

	void Update()
    {

		Timer -= Time.deltaTime;

		if (Timer <= 0)
        {
			Destroy(gameObject);
        }

	
    }

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Enemy")
		{
			Destroy(gameObject);
			Destroy(collision.collider.gameObject);
			scoreScript.scoreValue += 1000;
			
		}

		if (collision.gameObject.tag == "coin")
        {
			coinCounter.coinValue += 1;
			Destroy(gameObject);
			Destroy(collision.collider.gameObject);
			
			
		}

	}
}
