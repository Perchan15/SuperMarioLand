using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollect : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        HealthScript controller = other.GetComponent<HealthScript>();
        ScoreScript counter = other.GetComponent<ScoreScript>();




        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }

            if (controller.health == controller.maxHealth)
            {
                counter.scoreValue += 1000;
                Destroy(gameObject);
            }


        }



    }
}
