using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{

    public AudioSource audioSource;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.Play();

            Destroy(GameObject.Find("MiniShpinx 1 (4)"));
            Destroy(GameObject.Find("Boss Chain"));
            Destroy(GameObject.Find("Boss Door"));
            Destroy(gameObject);
        }
    }
}
