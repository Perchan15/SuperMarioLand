using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public int health { get { return currentHealth; } }

    public Sprite Grow;

    public Sprite Small;

    public float timeInvincible = 2.0f;
    bool isInvincible;
    float invincibleTimer;

    public ScoreScript scoreScript;

    public AudioSource audioSource;
    public AudioSource powerUpSound;

    //public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 1;

    }

    // Update is called once per frame
    void Update()
    {

        if (currentHealth == 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        }

        if (currentHealth >= 2)
        {
            currentHealth = 2;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            if (currentHealth == 2)
            {
                transform.localScale /= 1.2f;
            }
            currentHealth -= 1;
            audioSource.Play();
            if (isInvincible)
                return;

            isInvincible = true;
            invincibleTimer = timeInvincible;
            
        }

        if (collision.collider.tag == "Mushroom")
        {
            if (currentHealth == 1)
            {
                powerUpSound.Play();
                transform.localScale *= 1.2f;
                currentHealth += 1;
            }
            Destroy(collision.collider.gameObject);
            scoreScript.scoreValue += 1000;
            scoreScript.score.text = scoreScript.scoreValue.ToString();

            if (currentHealth == maxHealth)
            {
                Destroy(collision.collider.gameObject);
            }

        }

        if (collision.collider.tag == "PowerFlower")
        {
            powerUpSound.Play();
            scoreScript.scoreValue += 1000;
            scoreScript.score.text = scoreScript.scoreValue.ToString();
            if (currentHealth == 1)
            {
                currentHealth += 1;
            }
        }

        if (collision.collider.tag == "spinx")
        {
            if (currentHealth == 2)
            {
                transform.localScale /= 1.2f;
            }
            currentHealth -= 1;
            audioSource.Play();
            if (isInvincible)
                return;

            isInvincible = true;
            invincibleTimer = timeInvincible;

        }

    }

}
