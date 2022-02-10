using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_Script : MonoBehaviour
{
    public float countdownTime;
    public Text coundownDesplay;

    public GameObject backgroundMusic;
    public GameObject backgroundMusicFast;


    // Start is called before the first frame update
    void Start()
    {
        AudioSource audioSource;
        audioSource = GetComponent<AudioSource>();

        backgroundMusic.SetActive(false);
        backgroundMusicFast.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        countdownTime -= Time.deltaTime;
        coundownDesplay.text = "" + Mathf.Round(countdownTime);

        if (countdownTime <= 400)
        {
            backgroundMusic.SetActive(true);
        }

        if (countdownTime <= 390)
        {
            backgroundMusic.SetActive(false);
            backgroundMusicFast.SetActive(true);

        }


    }
}
