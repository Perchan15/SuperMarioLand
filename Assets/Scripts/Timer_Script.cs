using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_Script : MonoBehaviour
{
    public float countdownTime;
    public Text coundownDesplay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countdownTime -= Time.deltaTime;
        coundownDesplay.text = "" + Mathf.Round(countdownTime);

    }
}
