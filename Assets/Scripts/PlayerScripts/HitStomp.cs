using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStomp : MonoBehaviour
{
    public float bounce;
    public Rigidbody2D rb2D;

    public ScoreScript scoreScript;

    ParticleOnDestroy particleScript;
    
    public AudioSource audioSource;

    public Sphinx sphinx;

    // Start is called before the first frame update
    void Start()
    {
        particleScript = GetComponent<ParticleOnDestroy>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            audioSource.Play();
            particleScript.SpawnParticle(other.transform.position);
            rb2D.velocity = new Vector2(rb2D.velocity.x, bounce);
            scoreScript.scoreValue += 1000;
            scoreScript.score.text = scoreScript.scoreValue.ToString();
        }

    }
}
