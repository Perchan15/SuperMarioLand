using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int coinValue = 0;
    public Text score;
    public AudioSource audioSource;

    void start()
    {

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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "coin")
        {
            
            Destroy(other.gameObject);
            audioSource.Play();
            coinValue += 1;
            score.text = coinValue.ToString();
        }


    }


   

}
