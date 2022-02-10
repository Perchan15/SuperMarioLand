using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 1;


    }

    // Update is called once per frame
    void Update()
    {

        if (currentHealth == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Grow;

        }

        if (currentHealth == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Small;
        }

        if (currentHealth == 0)
        {
            Destroy(gameObject);
        }

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            currentHealth -= 1;
            if (isInvincible)
                return;

            isInvincible = true;
            invincibleTimer = timeInvincible;

        }
    }

    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
