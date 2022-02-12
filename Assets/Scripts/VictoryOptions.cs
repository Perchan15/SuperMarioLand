using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryOptions : MonoBehaviour
{
    public Vector3 location1;
    public Vector3 location2;

    private bool exitChoice;
    void Start()
    {
        exitChoice = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right") || Input.GetKeyDown("d") || Input.GetKeyDown("left") || Input.GetKeyDown("a"))
        {
            if (exitChoice == false)
            {
                exitChoice = true;
                MoveCursor(location2);
            }
            else if (exitChoice == true)
            {
                exitChoice = false;
                MoveCursor(location1);
            }
        }

        if (Input.GetKeyDown("space") || Input.GetKeyDown("return") || Input.GetKeyDown("k"))
        {
            if (exitChoice == false)
            {
                SceneManager.LoadScene("Menu");
            }
            else
            {
                Application.Quit();
            }
        }

    }
    void MoveCursor(Vector3 location)
    {
        transform.position = location;
    }
}
