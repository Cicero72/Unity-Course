using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloWorld : MonoBehaviour
{
    int max;
    int min;
    int guess;


    // Use this for initialization
    void Start()
    {
        startGame();
        max = max + 1;
        min = min - 1;
    }
    void startGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Is it higher or lower than " + guess);
    }
    void nextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess);
    }
    // Update is called once per frame
    void Update()
    {
        // Up
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            nextGuess();
        }
        // Down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            nextGuess();
        }
        // Enter
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You win, congrats!");
            startGame();
        }

    }
}
