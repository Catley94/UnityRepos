using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maximumNumber = 1000;
    int minimumNumber = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        
        //Initial messages
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number");
        Debug.Log($"Highest number is: {maximumNumber}");
        Debug.Log($"Lowest number is: {minimumNumber}");
        Debug.Log($"Tell me if your number is higher or lower than {guess}");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        //Max number 1001, allowing the max number to be 1000
        maximumNumber = maximumNumber + 1;

    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            minimumNumber = guess;
            //Generate new guess
            guess = (maximumNumber + minimumNumber) / 2;
            Debug.Log($"Is it higher or lower than {guess}?");
        } else if(Input.GetKeyDown(KeyCode.DownArrow)) {
            maximumNumber = guess;
            //Generate new guess
            guess = (maximumNumber + minimumNumber) / 2;
            Debug.Log($"Is it higher or lower than {guess}?");
        } else if(Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Excellent, we're on the same wave length!");
        }
        
    }
}
