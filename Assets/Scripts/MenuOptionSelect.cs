using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptionSelect : MonoBehaviour
{
    private int choice;
    // Start is called before the first frame update
    void Start()
    {
        choice = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Cycles options with arrow keys
        if (Input.GetKeyDown("down"))
        {
            if (choice < 3)
            {
                choice++;
            }
            else
            {
                choice = 1;
            }
        }
        //Selects option
        if (Input.GetKeyDown("space"))
        {
            if (choice == 1)
            {
                SceneManager.LoadScene("Level 1");
            }
            else if (choice == 2)
            {
                SceneManager.LoadScene("About");
            }
        }
    }
}
