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
	public Sphinx sphinx; 

	public AudioSource audioSource;

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
			audioSource.Play();
			Destroy(collision.collider.gameObject);
			Destroy(gameObject);
			scoreScript.scoreValue += 1000;
			scoreScript.score.text = scoreScript.scoreValue.ToString();
		}

		if (collision.gameObject.tag == "spinx")
        {
			audioSource.Play();
			sphinx.Health -= 1;
			Destroy(gameObject);
		}

	}

	void OnTriggerEnter2D(Collider2D other)
    {
		if (other.tag == "coin")
		{
			coinCounter.audioSource.Play();
			Destroy(gameObject);
			Destroy(other.gameObject);
			coinCounter.coinValue += 1;
			coinCounter.score.text = coinCounter.coinValue.ToString();
		}

	}


}
