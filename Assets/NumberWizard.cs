using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to Number Wizard bois.");
        Debug.Log("Pick yer number of choice:");
        Debug.Log("Highest ya can go is: " + max);
        Debug.Log("Lowest ya can go is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        NextGuess();

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("We got the correct answer? Nice!");
            StartGame();
        }

    }

    void NextGuess()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("It's higher than " + guess + " then.");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it: " + guess + " ?");
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("It's lower than " + guess + " then.");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it: " + guess + " ?");
        }
    }
}
