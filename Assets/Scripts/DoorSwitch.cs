using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(GameObject.Find("Grand Sphinx"));
            Destroy(GameObject.Find("Boss Chain"));
            Destroy(GameObject.Find("Boss Door"));
            Destroy(gameObject);
        }
    }
}
