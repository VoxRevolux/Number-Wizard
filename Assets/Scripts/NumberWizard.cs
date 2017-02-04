using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start () {
        max = 1000;
        min = 1;
        guess = 500;
        StartingMessages();
	}
	
	// Update is called once per frame
	void Update () {
        NextGuess();
    }

    void StartingMessages()
    {
        print("==========================================");
        print("Welcome to Number Wizard");
        print("Pick a number, but don't tell me, madafaka");


        print("The highest number you can pick is " + max);
        print("The lowest one you can pick is " + min);

        print("Is your number higher or lower than " + guess + "?");
        print("Use Up Arrow = higher, Down Arrow = lower and Enter = equal");
        guess++;
    }

    void NextGuess()
    {
        if( Input.GetKeyDown(KeyCode.UpArrow) )
        {
            //If it's higher
            min = guess;
            guess += ( max - min ) / 2;
            print(guess);
        }
        else if( Input.GetKeyDown(KeyCode.DownArrow) )
        {
            //If it's lower
            max = guess;
            guess -= ( max - min ) / 2;
            print(guess);
        }
        else if( Input.GetKeyDown(KeyCode.Return) )
        {
            //If it's the exact number
            print("That's it, man!");
            Start();

        }
    }
}
