using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") || Input.GetKeyDown("return") || Input.GetKeyDown("k"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
