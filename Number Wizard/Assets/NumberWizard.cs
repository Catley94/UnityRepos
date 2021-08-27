using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int maximumNumber = 1000;
        int minimumNumber = 1;
        
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number");
        Debug.Log($"Highest number is: {maximumNumber}");
        Debug.Log($"Lowest number is: {minimumNumber}");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
