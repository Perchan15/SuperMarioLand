using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int scoreValue = 0;
    public Text score;



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "coin")
        {
            scoreValue += 100;
        }
    }
}
