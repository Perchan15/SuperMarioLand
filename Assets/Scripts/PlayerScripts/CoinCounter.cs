using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int coinValue = 0;
    public Text score;
    public AudioClip Coinsound;
    AudioSource audioSource;

    void start()
    {
        audioSource = GetComponent<AudioSource>();
        score.text = coinValue.ToString();

    }

    void update()
    {
        if (coinValue >= 100)
        {
            coinValue = 0;
        }

        if (coinValue >= 0)
        {
            score.text = "X " + coinValue.ToString();
        }

        
    }




    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "coin")
        {
            Destroy(collision.collider.gameObject);
            coinValue += 1;
            score.text = coinValue.ToString();

            PlaySound(Coinsound);
        }
    }



    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

}
