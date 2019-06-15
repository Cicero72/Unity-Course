using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloWorld : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;


    // Use this for initialization
    void Start()
    {
        int hitpoints = 20;
        Debug.Log(hitpoints);

    }

    // Update is called once per frame
    void Update()
    {
        // Up
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow");
            min = guess;
        }
        // Down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow");
            max = guess;
        }
        // Enter
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter");
            guess = 700;
        }

    }
}
