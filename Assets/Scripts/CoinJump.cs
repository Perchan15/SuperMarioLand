using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinJump : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.5f);
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

}
