using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptionSelect : MonoBehaviour
{
    public Vector3 startLocation;
    public Vector3 aboutLocation;
    public Vector3 exitLocation;

    private string choice;
    // Start is called before the first frame update
    void Start()
    {
        choice = "start";
    }

    // Update is called once per frame
    void Update()
    {
        //Cycles options with arrow keys
        if (Input.GetKeyDown("down") || Input.GetKeyDown("s"))
        {
            if (choice == "start")
            {
                choice = "about";
                MoveCursor(aboutLocation);
            }
            else if (choice == "about")
            {
                choice = "exit";
                MoveCursor(exitLocation);
            }
            else if (choice == "exit")
            {
                choice = "start";
                MoveCursor(startLocation);
            }
        }
        else if (Input.GetKeyDown("up") || Input.GetKeyDown("w"))
        {
            if (choice == "start")
            {
                choice = "exit";
                MoveCursor(exitLocation);
            }
            else if (choice == "exit")
            {
                choice = "about";
                MoveCursor(aboutLocation);
            }
            else if (choice == "about")
            {
                choice = "start";
                MoveCursor(startLocation);
            }
        }
        //Selects option
        if (Input.GetKeyDown("space") || Input.GetKeyDown("return") || Input.GetKeyDown("k"))
        {
            if (choice == "start")
            {
                SceneManager.LoadScene("Level 1");
            }
            else if (choice == "about")
            {
                SceneManager.LoadScene("about");
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
